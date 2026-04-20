using Cleaning_Layer.Report_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Layer.Features
{
    public class clsNullEmptyDetectionFeature : ICleaningFeature
    {

        
         

        clsConfiguration _config;
        clsSchema _Schema;
        clsFeatureReport _report = new clsFeatureReport();

        public clsNullEmptyDetectionFeature(clsConfiguration config,clsSchema Schema)
        {
            _Schema = Schema;
            _config = config;

        }
       // Action<List<List<string>>, int, int> _handleMissingData;
        Func< int,string> _handleMissingData;
        void PrepareOptionAction()
        {
            if (_config.ReplaceOption == clsConfiguration.enReplaceOption.ReplaceWithNA)
            {
                _handleMissingData   = (j) => { _report.UpdatedRecordsAffected++; return "N/A"; };
            }
            else if (_config.ReplaceOption == clsConfiguration.enReplaceOption.RemoveRow )
            {
                _handleMissingData = (j) => { _report.RemovedRecordsAffected++; return ""; };
            }
            else if (_config.ReplaceOption == clsConfiguration.enReplaceOption.DefaultValue)
            {
                _handleMissingData = (j) =>  { _report.UpdatedRecordsAffected++; return _Schema.GetColumnByIndex(j).DefaultValue; };
            }
            else
            {
                throw new InvalidOperationException("Invalid null/empty handling option.");
            }

        }

        //this method detects null and empty values in the dataset and replaces them with with a "N/A" or remove row(Only for now)
        public clsFeatureReport Apply(List<List<string>> data)
        {

            PrepareOptionAction();

            for (int i = 0; i < data.Count; i++)
            {
                var row = data[i];
                for (int j = 0; j < row.Count; j++)
                {
                    if (string.IsNullOrEmpty(row[j]))
                    {
                        // Replace null or empty values with "N/A"
                        row[j] = _handleMissingData(j);
                    }

                }

            }
            return _report;

        }

    }

}
