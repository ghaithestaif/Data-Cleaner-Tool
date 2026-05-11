using Cleaning_Layer.Report_Classes;
using System;
using System.Collections.Generic;

namespace Cleaning_Layer.Features
{
    public class clsRemoveRowsFeature : ICleaningFeature
    {
        private readonly clsConfiguration _config;
        private readonly clsFeatureReport _report = new clsFeatureReport();

        public clsRemoveRowsFeature(clsConfiguration config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public clsFeatureReport Apply(List<List<string>> data)
        {

            if (data == null || data.Count == 0)
            {
                return new clsFeatureReport() { Feature = clsFeatureReport.enfeatureName.RemoveDuplicates };
            }

            if (_config.NumberOfIRemovedRows <= 0)
            {
                return _report;
            }

            int startIndex = 0;

            if (data.Count <= startIndex)
            {
                return _report;
            }
            //this method return the smallest between the tow numbers
            int rowsToRemove = Math.Min(_config.NumberOfIRemovedRows  , data.Count - startIndex);

            data.RemoveRange(startIndex, rowsToRemove);

            _report.Feature = clsFeatureReport.enfeatureName.IgnoreRows;
            _report.RemovedRecordsAffected = rowsToRemove;

            return _report;
        }
    }
}