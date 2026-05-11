using Cleaning_Layer.Features;
using Cleaning_Layer.Report_Classes;
using Cleaning_Layer.Schema_Classes;
using DocumentFormat.OpenXml.Presentation;
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
      public enum enState       
        {
            NotStarted,
            InProgress,
            Completed,
            
        }
        public enState State { get; private set; } = enState.NotStarted;


        public class DataUpdatedEventArgs : EventArgs
        {
            public IReadOnlyList<List<string>> Data { get; }
            public clsSchema Schema { get; }
            public IReadOnlyList<clsFeatureReport> FeaturesReports { get; }
            public clsConfiguration Config { get; }
            public DataUpdatedEventArgs(IReadOnlyList<List<string>> data, clsSchema schema, clsConfiguration config, IReadOnlyList<clsFeatureReport> featuresReports )
            {
                Data = data;
                Schema = schema;
                FeaturesReports = featuresReports;
                Config = config;
            }
        }

        public event EventHandler<DataUpdatedEventArgs> DataUpdated;

        protected virtual void OnDataUpdated(DataUpdatedEventArgs e)
        {
            State=enState.Completed;
            DataUpdated?.Invoke(this, e);
        }

       public clsSchema Schema { get { return _schema; } }
        public IReadOnlyList<List<string>> ReadOnlyData { get { return _data.AsReadOnly(); } }

        List<ICleaningFeature> _features = new List<ICleaningFeature>();

        private bool validateConfiguration(clsConfiguration config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(_config), "Configuration cannot be null.");
            }

            if (string.IsNullOrEmpty(config.FilePathwithFileName))
            {
                throw new ArgumentException("File path cannot be null or empty.", nameof(config.FilePathwithFileName));
            }

            if (!File.Exists(config.FilePathwithFileName))
            {
                throw new FileNotFoundException("The specified file does not exist.", config.FilePathwithFileName);
            }

            return true;
        }

        List<List<string>> _ImportData(int SheetNumber)
        {
            State = enState.InProgress;
            string extension = Path.GetExtension(_config.FilePathwithFileName).ToLower();

            switch (extension)
            {
                case ".xlsx":
                case ".xls":
                    return clsExtract.ExtractExcelData(_config.FilePathwithFileName, SheetNumber);
                case ".csv":
                    return clsExtract.ExtractCSVData(_config.FilePathwithFileName);
                default:
                    throw new NotSupportedException("Unsupported file type: " + extension);

            }

        }
        public void ExtractData(int SheetNumber)
        {    
            _data = _ImportData(SheetNumber);
            _schema = clsGenerateSchema.GenerateSchema(ref _data);
            OnDataUpdated(new DataUpdatedEventArgs(ReadOnlyData, _schema, _config, null));
        }
        public clsClean(clsConfiguration config)
        {
            if (!validateConfiguration(config))
            {
                return;
            }
            _config = config;
        }

        private void _AddFeatures()
        {
            _features.Clear();
            if (_config.NumberOfIRemovedRows > 0)
            {
                _features.Add(new clsRemoveRowsFeature(_config));
            }
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
            
        }

        public bool Clean()
        {
            State=enState.InProgress;
            _AddFeatures();

            foreach (var feature in _features)
            {
                clsFeatureReportManager.AddFeatureReport(feature.Apply(_data));
            }

            OnDataUpdated(new DataUpdatedEventArgs(ReadOnlyData, _schema, _config, clsFeatureReportManager.FeaturesReports));

            return true;
        }

        public void UpdateConfig(clsConfiguration Config)
        {
            validateConfiguration(Config);
            _config = Config;   
        }


    }
}
