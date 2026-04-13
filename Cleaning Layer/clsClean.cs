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
        static public List<List<string>> CleanData(string filePath)
        {
            return clsExtract.ExtractExcelData(filePath);
        }



    }
}
