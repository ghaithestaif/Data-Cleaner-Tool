using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using ExcelDataReader;

namespace Extraction_layer
{
    public class clsExtract
    {
        //this function reads the excel file and returns a list of lists of strings, where each inner list represents a row of data from the excel file
        // reads on sheet because the tool deals with one table
        static public List<List<string>> ExtractExcelData(string filePath)
        {
            var data = new List<List<string>>();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    

                    while (reader.Read())
                    {

                        var row = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Add(reader.GetValue(i)?.ToString() ?? string.Empty);
                        }
                        data.Add(row);
                    }
                    //next sheet
                    
                }
            }
            return data;
        }
        //this function reads a CSV file and returns a list of lists of strings, where each inner list represents a row of data from the CSV file
        static public List<List<string>> ExtractCSVData(string filePath)
        {
            var data = new List<List<string>>();
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    data.Add(new List<string>(values));
                }
            }
            return data;
        }

    }
}
