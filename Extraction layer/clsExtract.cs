using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Extraction_layer
{
    public class clsExtract
    {
        // this function deletes columns that are entirely empty from the data, it takes a list of lists of strings as input and returns a cleaned list of lists of strings
        static List<List<string>> _DeleteInvalidColumns(List<List<string>> data)
        {
            // Identify columns that are entirely empty
            var emptyColumns = new HashSet<int>();
            for (int col = 0; col < data[0].Count; col++)
            {
                bool isEmpty = true;
                foreach (var row in data)
                {
                    if (!string.IsNullOrWhiteSpace(row[col]))
                    {
                        isEmpty = false;
                        break;
                    }
                }
                if (isEmpty)
                {
                    emptyColumns.Add(col);
                }
            }

            // Remove empty columns
            var cleanedData = new List<List<string>>();
            foreach (var row in data)
            {
                var cleanedRow = new List<string>();
                for (int col = 0; col < row.Count; col++)
                {
                    if (!emptyColumns.Contains(col))
                    {
                        cleanedRow.Add(row[col]);
                    }
                }
                cleanedData.Add(cleanedRow);
            }
            return cleanedData;
        }



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
                            
                            row.Add((reader.GetValue(i)?.ToString() ?? string.Empty).Trim());
                        }
                        data.Add(row);
                    }
                    //next sheet
                    
                }
            }

            //now we have the data in a list of lists of strings, we can return it but we need to clean the empty columns and rows



            return _DeleteInvalidColumns(data);
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
                    var row = new List<string>();
                    foreach (var value in values)
                    {
                        row.Add(value.Trim());
                    }
                    data.Add(row);
                }
            }
            return data;
        }

    }
}
