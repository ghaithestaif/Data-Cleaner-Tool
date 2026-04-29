using Cleaning_Layer.Report_Classes;
using System;
using System.Collections.Generic;

namespace Cleaning_Layer.Features
{
    public class clsIgnoreRowsFeature : ICleaningFeature
    {
        private readonly clsConfiguration _config;
        private readonly clsFeatureReport _report = new clsFeatureReport();

        public clsIgnoreRowsFeature(clsConfiguration config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public clsFeatureReport Apply(List<List<string>> data)
        {
            if (data == null || data.Count == 0)
            {
                return _report;
            }

            if (_config.NumberOfIgnoredRows <= 0)
            {
                return _report;
            }

            int startIndex = _config.HasHeader ? 1 : 0;

            if (data.Count <= startIndex)
            {
                return _report;
            }
            //this method return the smallest between the tow numbers
            int rowsToRemove = Math.Min(_config.NumberOfIgnoredRows  , data.Count - startIndex);

            data.RemoveRange(startIndex, rowsToRemove);

            _report.Feature = clsFeatureReport.enfeatureName.IgnoreRows;
            _report.RemovedRecordsAffected = rowsToRemove;

            return _report;
        }
    }
}