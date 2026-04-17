using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Layer
{
    public class clsNullEmptyDetectionFeature : ICleaningFeature
    {

        
         

        clsConfiguration _config;
        clsSchema _Schema;
        public clsNullEmptyDetectionFeature(clsConfiguration config,clsSchema Schema)

        {
            _Schema = Schema;
            _config = config;

        }
        Action<List<List<string>>, int, int> _handleMissingData;
        void PrepareOptionAction()
        {
            if (_config.ReplaceOption == clsConfiguration.enReplaceOption.ReplaceWithNA)
            {
                _handleMissingData   = (data, i, j) => data[i][j] = "N/A";
            }
            else if (_config.ReplaceOption == clsConfiguration.enReplaceOption.RemoveRow )
            {
                _handleMissingData = (data, i, j) => data.RemoveAt(i);
            }
            else if (_config.ReplaceOption == clsConfiguration.enReplaceOption.DefaultValue)
            {
                _handleMissingData = (data, i, j) => data[i][j] = _Schema.GetColumnByIndex(j).DefaultValue;
            }
            else
            {
                throw new InvalidOperationException("Invalid null/empty handling option.");
            }

        }

        //this method detects null and empty values in the dataset and replaces them with with a "N/A" or remove row(Only for now)
        public void Apply(List<List<string>> data)
        {
            PrepareOptionAction();

            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].Count; j++)
                {
                    if (string.IsNullOrEmpty(data[i][j]))
                    {
                        // Replace null or empty values with "N/A"
                        _handleMissingData (data, i, j);
                    }

                }

            }

        }

    }

}
