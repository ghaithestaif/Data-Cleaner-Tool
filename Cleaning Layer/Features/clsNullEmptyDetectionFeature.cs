using Cleaning_Layer.Report_Classes;
using System;
using System.Collections.Concurrent; // 1. ADDED THIS
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Cleaning_Layer.Features
{
    public class clsNullEmptyDetectionFeature : ICleaningFeature
    {
        clsConfiguration _config;
        clsSchema _Schema;
        clsFeatureReport _report = new clsFeatureReport();
        int RemoveRowsCount = 0;
        int UpdateRowsCount = 0;

        public clsNullEmptyDetectionFeature(clsConfiguration config,clsSchema Schema)
        {
            _Schema = Schema;
            _config = config;
        }

        Func<int,string> _handleMissingData;
        void PrepareOptionAction()
        {
            if (_config.ReplaceOption == clsConfiguration.enReplaceOption.ReplaceWithNA)
            {
                _handleMissingData   = (j) => { Interlocked.Increment(ref UpdateRowsCount); return "N/A"; };
            }
            else if (_config.ReplaceOption == clsConfiguration.enReplaceOption.RemoveRow )
            {
                // We don't increment here anymore because the loop will handle the increment
                _handleMissingData = (j) => { return ""; };
            }
            else if (_config.ReplaceOption == clsConfiguration.enReplaceOption.DefaultValue)
            {
                _handleMissingData = (j) =>  { Interlocked.Increment(ref UpdateRowsCount); return _Schema.GetColumnByIndex(j).DefaultValue; };
            }
            else
            {
                throw new InvalidOperationException("Invalid null/empty handling option.");
            }
        }

        public clsFeatureReport Apply(List<List<string>> data)
        {
            PrepareOptionAction();
            

            ConcurrentBag<int> rowsToRemove = new ConcurrentBag<int>();
            
            Parallel.For(0, data.Count, i =>
            {
                bool markForRemoval = false;
                var row = data[i];
                
                for (int j = 0; j < row.Count; j++)
                {
                    if (string.IsNullOrEmpty(row[j]))
                    {
                        if(_config.ReplaceOption == clsConfiguration.enReplaceOption.RemoveRow)
                        {
                            markForRemoval = true;
                            break; // 3. This exits the 'j' loop immediately
                        }
                        
                        // Replace null or empty values with "N/A"
                        row[j] = _handleMissingData(j);
                    }
                } 

                if(markForRemoval)
                {
                    Interlocked.Increment(ref RemoveRowsCount);
                    rowsToRemove.Add(i);
                }
            });

            // PHASE 2: Remove marked rows
            if (rowsToRemove.Count > 0)
            {
                // Sort indices in descending order to avoid shifting issues when removing
                foreach (var index in rowsToRemove.OrderByDescending(x => x)) 
                {
                    data.RemoveAt(index);
                }        
            }

            // Update the report with the thread-safe counts
            _report.UpdatedRecordsAffected = UpdateRowsCount;
            _report.RemovedRecordsAffected = RemoveRowsCount;
            return _report;
        }
    }
}
