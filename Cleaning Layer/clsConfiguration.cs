using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Layer
{
    public class clsConfiguration
    {
        public bool RemoveDuplicates { get; set; }=     false;
        public bool HandleMissingValues { get; set; }=false;

        public bool StandardizeData { get; set; }=false;

        public string? FilePath { get; set; }
        public string? FileName { get; set; }




    }
}
