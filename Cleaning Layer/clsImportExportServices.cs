using Extraction_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cleaning_Layer
{
    public class clsImportExportServices
    {

        public static Dictionary<int, string> GetExcelSheetNames(string filePath)
        {
            return clsExtract.GetExcelSheetNames(filePath);
        }
        
        public static void ExportData(IReadOnlyList<List<string>> data, string filePath, string sheetname)
        {
            string extension = Path.GetExtension(filePath).ToLowerInvariant();

            if (extension == ".xlsx" || extension == ".xls")
            {
                clsExtract.WriteToExcel(data, filePath, sheetname);
            }
            else if (extension == ".csv")
            {
                clsExtract.WriteToCsv(data, filePath);
            }
            else
            {
                throw new NotSupportedException($"Unsupported export file type: {extension}");
            }
        }





    }
}
