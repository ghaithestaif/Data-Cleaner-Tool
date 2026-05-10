using Cleaning_Layer.Report_Classes;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Layer.Features
{
    public class clsRemoveDuplicatesFeature : ICleaningFeature
    {
        //this feature will remove duplicate rows from the data
        public clsFeatureReport Apply( List<List<string>> data)
        {
            if (data == null || data.Count == 0)
            {
                return new clsFeatureReport()
                {
                    Feature = clsFeatureReport.enfeatureName.RemoveDuplicates
                };
            }

            clsFeatureReport _report = new clsFeatureReport();

            // remove duplicates safely using a stable key
            List<List<string>> newData = data
                .DistinctBy(row => string.Join("\u001F", row))
                .ToList();

            // calculate how many were removed
            _report.RemovedRecordsAffected = data.Count - newData.Count;

            // replace original data
            data.Clear();
            data.AddRange(newData);

            return _report;
        }
    }
}
