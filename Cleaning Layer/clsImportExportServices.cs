using Extraction_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Layer
{
    public class clsImportExportServices
    {

        public static Dictionary<int, string> GetExcelSheetNames(string filePath)
        {
            return clsExtract.GetExcelSheetNames(filePath);
        }
        
        public static void ExportToExcel(IReadOnlyList<List<string>> data, string filePath,string sheetname)
        {
            clsExtract.WriteToExcel( data, filePath,sheetname);
        }

        public static void ExportToCsv(IReadOnlyList<List<string>> data, string filePath)
        {
            clsExtract.WriteToCsv(data, filePath);
        }





    }
}
