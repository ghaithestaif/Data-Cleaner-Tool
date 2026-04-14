using Extraction_layer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Cleaning_Layer
{
    public class clsClean
    {
        clsConfiguration _config;
        List<List<string>> _data;
        public clsClean(clsConfiguration config)
        {
            _config = config;
            if(!validateConfiguration())
            {
                return;
            }
            _data =_ImportData();
            //_data.ForEach(row =>
            //{
            //    Console.WriteLine(string.Join(" ", row));
            //});
        }

        private bool validateConfiguration()
        {
            if (_config == null)
            {
                throw new ArgumentNullException(nameof(_config), "Configuration cannot be null.");
            }
            if (string.IsNullOrEmpty(_config.FilePath))
            {
                throw new ArgumentException("File path cannot be null or empty.", nameof(_config.FilePath));
            }
            if (!File.Exists(_config.FilePath))
            {
                throw new FileNotFoundException("The specified file does not exist.", _config.FilePath);
            }
            return true;
        }
        List<List<string>> _ImportData()
        {
           // Determine file type based on extension and call appropriate import method
           string extension = Path.GetExtension(_config.FilePath).ToLower();

           switch (extension)
           {
               case ".xlsx":
               case ".xls":
                   return clsExtract.ExtractExcelData(_config.FilePath);
               case ".csv":
                   return clsExtract.ExtractCSVData(_config.FilePath);
               default:
                   throw new NotSupportedException("Unsupported file type: " + extension);
           }
            
        }


        
        




        


    }
}
