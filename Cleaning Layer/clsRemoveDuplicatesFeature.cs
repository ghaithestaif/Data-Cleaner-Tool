using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Layer
{
    public class clsRemoveDuplicatesFeature : ICleaningFeature
    {
        //this feature will remove duplicate rows from the data
        public void Apply( List<List<string>> data)
        {
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
                
            }
            data.Clear();
            data.AddRange(newData);


        }
    }
}
