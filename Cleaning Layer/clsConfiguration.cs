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
            ReplaceWithNA,
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
        public enReplaceOption? ReplaceOption { get; set; } = enReplaceOption.ReplaceWithNA;
        public bool RemoveDuplicates { get; set; } = false;
        public bool HandleMissingValues { get; set; } = false;
        public bool StandardizeData { get; set; } = false;

        public string? FilePathwithFileName { get; set; }
        public string? FileName { get; set; }
        public string? Extension { get { return System.IO.Path.GetExtension(FilePathwithFileName); } }

        public bool HasHeader { get; set; } = true;

        public int NumberOfIgnoredRows { get; set; } = 0;
    }
}
