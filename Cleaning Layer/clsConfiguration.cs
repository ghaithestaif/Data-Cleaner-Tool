using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Layer
{
    public class clsConfiguration
    {
        public enum enReplaceOption
        {
            
            RemoveRow,
            DefaultValue
        }

        public enum enCasingStanderdizationOption
        {
            TitleCase,
            UpperCase,
            LowerCase
        }

        public enCasingStanderdizationOption? StanderdizeDataOption { get; set; } = null;
        public enReplaceOption? ReplaceOption { get; set; } = enReplaceOption.DefaultValue;
        public bool RemoveDuplicates { get; set; } = false;
        public bool HandleMissingValues { get; set; } = false;
        public bool StandardizeData { get; set; } = false;

        public string? FilePathwithFileName { get; set; }
        public string? FileName { get { return Path.GetFileName(FilePathwithFileName); } }
        public string? Extension { get { return System.IO.Path.GetExtension(FilePathwithFileName); } }


        public int NumberOfIgnoredRows { get; set; } = 0;

        public int SheetNumber { get; set; } = -1;
        public string? SheetName { get; set; }

       public void resetCleaningOptions()
        {
            
            NumberOfIgnoredRows = 0;
            StanderdizeDataOption = null;
            ReplaceOption = enReplaceOption.DefaultValue;
            RemoveDuplicates = false;
            HandleMissingValues = false;
            StandardizeData = false;
        }



    }
}
