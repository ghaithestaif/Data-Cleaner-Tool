using Extraction_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Layer
{
    public class clsImportServices
    {

        public static Dictionary<int, string> GetExcelSheetNames(string filePath)
        {
            return clsExtract.GetExcelSheetNames(filePath);
        }
    }
}
