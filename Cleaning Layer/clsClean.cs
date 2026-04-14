using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extraction_layer;
namespace Cleaning_Layer
{
    public class clsClean
    {
        static public List<List<string>> ImportExcelData(string filePath)
        {
            return clsExtract.ExtractExcelData(filePath);
        }
        static public List<List<string>> ImportCSVData(string filePath)
        {
            return clsExtract.ExtractCSVData(filePath);
        }



    }
}
