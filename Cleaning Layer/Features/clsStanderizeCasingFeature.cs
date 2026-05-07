using Cleaning_Layer.Report_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Cleaning_Layer.Features
{
    public class clsStanderizeCasingFeature : ICleaningFeature
    {
        clsSchema _Schema;
        clsConfiguration _Config;
        HashSet<int> _stringColumnsIndexes;
        clsFeatureReport _report = new clsFeatureReport();

        // Used for thread-safe counting
        private int _updatedRecords = 0;

        public clsStanderizeCasingFeature(clsConfiguration Config, clsSchema Schema)
        {
            _Config = Config;
            _Schema = Schema;
            PrepareOptionAction();
            _stringColumnsIndexes = getStringColumnsIndexes();
        }

        Func<string, string> _handleCasingStandard;

        void PrepareOptionAction()
        {
            // Note: We removed the counter logic from the delegates to handle it safely in the Parallel Loop
            if (_Config.StanderdizeDataOption == clsConfiguration.enCasingStanderdizationOption.TitleCase)
            {
                _handleCasingStandard = (input) => System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
            }
            else if (_Config.StanderdizeDataOption == clsConfiguration.enCasingStanderdizationOption.UpperCase)
            {
                _handleCasingStandard = (input) => input.ToUpper();
            }
            else if (_Config.StanderdizeDataOption == clsConfiguration.enCasingStanderdizationOption.LowerCase)
            {
                _handleCasingStandard = (input) => input.ToLower();
            }
            else
            {
                throw new InvalidOperationException("Invalid Casing option.");
            }
        }

        HashSet<int> getStringColumnsIndexes()
        {
            HashSet<int> stringColumnsIndexes = new HashSet<int>();
            foreach (var column in _Schema.Columns)
            {
                if (column.DataType == clsColumnSchema.enDataType.String)
                {
                    stringColumnsIndexes.Add(column.ID);
                }
            }
            return stringColumnsIndexes;
        }

        public clsFeatureReport Apply(List<List<string>> data)
        {
            if (data == null || data.Count == 0)
            {
                return new clsFeatureReport() { Feature = clsFeatureReport.enfeatureName.RemoveDuplicates };
            }
            // Reset counter
            _updatedRecords = 0;

            // Using Parallel.For instead of a standard for-loop to run processing on multiple CPU threads concurrently.
            Parallel.For(0, data.Count, i =>
            {
                var row = data[i];

                for (int j = 0; j < row.Count; j++)
                {
                    if (_stringColumnsIndexes.Contains(_Schema.GetColumnByIndex(j).ID) && !string.IsNullOrEmpty(row[j]))
                    {
                        // Clean the data
                        row[j] = _handleCasingStandard(row[j]);

                        // Ensure thread-safe counting across multiple cores!
                        Interlocked.Increment(ref _updatedRecords);
                    }
                }
            });

            // Put the completely safe total back into the report
            _report.UpdatedRecordsAffected = _updatedRecords;
            _report.Feature = clsFeatureReport.enfeatureName.StanderizeCasing;
            return _report;
        }
    }
}
