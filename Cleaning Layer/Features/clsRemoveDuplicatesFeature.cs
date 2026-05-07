using Cleaning_Layer.Report_Classes;
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
            if(data== null || data.Count == 0)
            {
                return new clsFeatureReport() { Feature = clsFeatureReport.enfeatureName.RemoveDuplicates };
            }
            clsFeatureReport _report = new clsFeatureReport();

            //let's make each row a string and add it to a hashset to remove duplicates

            HashSet<string> seen = new HashSet<string>();
            List<List<string>> newData = new List<List<string>>();

            for (int i = 0;i< data.Count; i++)
            {
                string rowString = string.Join(",", data[i]);
                if (seen.Add(rowString))
                {
                    newData.Add(data[i]);
                }
                else
                {
                    _report.RemovedRecordsAffected++;
                }
            }
            data.Clear();
            data.AddRange(newData);
            return _report;

        }
    }
}
