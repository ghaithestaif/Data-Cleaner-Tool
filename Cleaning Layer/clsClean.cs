using Cleaning_Layer.Features;
using Cleaning_Layer.Report_Classes;
using Cleaning_Layer.Schema_Classes;
using Extraction_layer;
using System;
using System.Collections.Generic;
using System.IO;

namespace Cleaning_Layer
{
    public class clsClean
    {
        clsConfiguration _config;

        List<List<string>> _data;

        clsSchema _schema;

        public List<List<string>> Data { get { return _data; } }
        public IReadOnlyList<List<string>> ReadOnlyData { get { return _data.AsReadOnly(); } }

        List<ICleaningFeature> _features = new List<ICleaningFeature>();

        private bool validateConfiguration()
        {
            if (_config == null)
            {
                throw new ArgumentNullException(nameof(_config), "Configuration cannot be null.");
            }

            if (string.IsNullOrEmpty(_config.FilePathwithFileName))
            {
                throw new ArgumentException("File path cannot be null or empty.", nameof(_config.FilePathwithFileName));
            }

            if (!File.Exists(_config.FilePathwithFileName))
            {
                throw new FileNotFoundException("The specified file does not exist.", _config.FilePathwithFileName);
            }

            return true;
        }

        List<List<string>> _ImportData()
        {
            string extension = Path.GetExtension(_config.FilePathwithFileName).ToLower();

            switch (extension)
            {
                case ".xlsx":
                case ".xls":
                    return clsExtract.ExtractExcelData(_config.FilePathwithFileName);
                case ".csv":
                    return clsExtract.ExtractCSVData(_config.FilePathwithFileName);
                default:
                    throw new NotSupportedException("Unsupported file type: " + extension);
            }

        }

        public clsClean(clsConfiguration config)
        {
            _config = config;

            if (!validateConfiguration())
            {
                return;
            }

            _data = _ImportData();
           // _ApplyInitialFeatures();
            _schema = clsGenerateSchema.GenerateSchema(_data);
        }

        private void _AddFeatures()
        {
            _features.Clear();

            if (_config.RemoveDuplicates)
            {
                _features.Add(new clsRemoveDuplicatesFeature());
            }

            if (_config.HandleMissingValues)
            {
                if (_config.ReplaceOption.HasValue)
                {
                    _features.Add(new clsNullEmptyDetectionFeature(_config, _schema));
                }
            }

            if (_config.StandardizeData)
            {
                if (_config.StanderdizeDataOption.HasValue)
                {
                    _features.Add(new clsStanderizeCasingFeature(_config, _schema));
                }
            }
            if(_config.NumberOfIgnoredRows > 0)
            {
                _features.Add(new clsIgnoreRowsFeature(_config));
            }
        }

        public bool Clean()
        {
            _AddFeatures();

            foreach (var feature in _features)
            {
                clsFeatureReportManager.AddFeatureReport(feature.Apply(_data));
            }

            return true;
        }

        public void UpdateConfig(clsConfiguration Config)
        {
            _config = Config;   
        }


    }
}
