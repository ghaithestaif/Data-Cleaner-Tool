using CsvHelper;
using CsvHelper.Configuration;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;


namespace Extraction_layer
{
    public class clsExtract
    {
        // this function deletes rows that are entirely empty from the data
        static List<List<string>> _DeleteInvalidRows(List<List<string>> data)
        {
            if (data == null)
                return new List<List<string>>();

            var cleanedData = new List<List<string>>();

            foreach (var row in data)
            {
                bool hasValue = false;

                foreach (var cell in row)
                {
                    if (!string.IsNullOrWhiteSpace(cell))
                    {
                        hasValue = true;
                        break;
                    }
                }

                if (hasValue)
                {
                    cleanedData.Add(row);
                }
            }

            return cleanedData;
        }

        // this function deletes columns that are entirely empty from the data
        static List<List<string>> _DeleteInvalidColumns(List<List<string>> data)
        {
            if (data == null || data.Count == 0)
                return new List<List<string>>();

            int maxColumns = 0;
            foreach (var row in data)
            {
                if (row != null && row.Count > maxColumns)
                {
                    maxColumns = row.Count;
                }
            }

            if (maxColumns == 0)
                return new List<List<string>>();

            // Identify columns that are entirely empty
            var emptyColumns = new HashSet<int>();
            for (int col = 0; col < maxColumns; col++)
            {
                bool isEmpty = true;

                foreach (var row in data)
                {
                    if (row != null && col < row.Count && !string.IsNullOrWhiteSpace(row[col]))
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

        // this function reads the excel file and returns a list of lists of strings, where each inner list represents a row of data from the excel file
        // reads on sheet because the tool deals with one table
        static public List<List<string>> ExtractExcelData(string filePath, int SheetNumber)
        {
            var data = new List<List<string>>();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    int currentSheet = 1;
                    do
                    {
                        if (currentSheet == SheetNumber)
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
                        }
                        currentSheet++;

                    } while (reader.NextResult());
                }
            }

            // remove empty rows, then remove empty columns
            data = _DeleteInvalidRows(data);
            data = _DeleteInvalidColumns(data);

            return data;
        }

        // this function reads a CSV file and returns a list of lists of strings, where each inner list represents a row of data from the CSV file
        static public List<List<string>> ExtractCSVData(string filePath)
        {
            var data = new List<List<string>>();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                //headers handled inside the system
                HasHeaderRecord = false,
                BadDataFound = null,
                MissingFieldFound = null,
                HeaderValidated = null
            };

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, config))
            {
                while (csv.Read())
                {
                    var row = new List<string>();

                    for (int i = 0; csv.TryGetField(i, out string field); i++)
                    {
                        row.Add(field?.Trim() ?? string.Empty);
                    }

                    data.Add(row);
                }
            }

            return data;
        }

        public static Dictionary<int, string> GetExcelSheetNames(string filePath)
        {
            //manage CSV
            if (Path.GetExtension(filePath).Equals(".csv", StringComparison.OrdinalIgnoreCase))
            {
                return new Dictionary<int, string> { { 0, Path.GetFileNameWithoutExtension(filePath) } };
            }

            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
            }

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file does not exist.", filePath);
            }

            var sheets = new Dictionary<int, string>();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                int sheetIndex = 0;

                do
                {
                    sheets.Add(sheetIndex, reader.Name);
                    sheetIndex++;
                }
                while (reader.NextResult());
            }

            return sheets;
        }

        public static void WriteToExcel(IReadOnlyList<List<string>> data, string filePath, string sheetName )
        {
            if (data == null || data.Count == 0) return;
            
            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(sheetName);
                for (int r = 0; r < data.Count; r++)
                {
                    for (int c = 0; c < data[r].Count; c++)
                    {
                        worksheet.Cell(r + 1, c + 1).Value = data[r][c];
                    }
                }
                workbook.SaveAs(filePath);
            }
        }

        public static void WriteToCsv(IReadOnlyList<List<string>> data, string filePath)
        {
            if (data == null || data.Count == 0) return;

            using (var writer = new StreamWriter(filePath))
            {
                foreach (var row in data)
                {
                    var escapedRow = new List<string>();
                    foreach (var field in row)
                    {
                        if (field == null)
                        {
                            escapedRow.Add("");
                            continue;
                        }
                        // Escape quotes and put fields with commas or quotes in quotes
                        string escapedField = field;
                        if (escapedField.Contains("\"") || escapedField.Contains(","))
                        {
                            escapedField = $"\"{escapedField.Replace("\"", "\"\"")}\"";
                        }
                        escapedRow.Add(escapedField);
                    }
                    writer.WriteLine(string.Join(",", escapedRow));
                }
            }
        }
    }
}
