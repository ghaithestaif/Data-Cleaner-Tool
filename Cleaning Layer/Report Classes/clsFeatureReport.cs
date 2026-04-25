using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Layer.Report_Classes
{
    public class clsFeatureReport
    {
        public enum enfeatureName
        {
            NullEmptyDetection,
            RemoveDuplicates,
            StanderizeCasing,
            IgnoreRows
        }

        public enfeatureName Feature { get; set; }

        public int RecordsAffected
        {
            get
            {
                return RemovedRecordsAffected + UpdatedRecordsAffected;
            }
        }

        public int RemovedRecordsAffected { get; set; } = 0;
        public int UpdatedRecordsAffected { get; set; } = 0;
    }
}
