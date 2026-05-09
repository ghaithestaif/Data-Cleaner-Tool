using System;
using System.Collections.Generic;
using System.Linq; // Added to enable LINQ for extracting columns

namespace Cleaning_Layer.Schema_Classes
{
    public class clsGenerateSchema
    {
        // A threshold of 0.8 means if 80% of the data matches a type, we assume that is the column's type.
        private const double Threshold = 0.80;

        static clsColumnSchema.enDataType GenerateColumnDataType(IEnumerable<string> columnData)
        {
            int intCount = 0, doubleCount = 0, boolCount = 0, dateTimeCount = 0, stringCount = 0;
            int nonEmptyCount = 0;

            // Iterate through the raw string stream cleanly!
            foreach (var cellValue in columnData)
            {
                string value = cellValue?.Trim();

                // Skip empty cells so they don't skew the percentages
                if (string.IsNullOrEmpty(value)) continue;

                nonEmptyCount++;

                // Waterfall parse: exact matches first
                if (bool.TryParse(value, out _))
                {
                    boolCount++;
                }
                else if (int.TryParse(value, out _))
                {
                    intCount++;
                }
                else if (double.TryParse(value, out _))
                {
                    doubleCount++;
                }
                else if (DateTime.TryParse(value, out _))
                {
                    dateTimeCount++;
                }
                else
                {
                    stringCount++;
                }
            }

            // If the column is entirely empty, default to String
            if (nonEmptyCount == 0)
            {
                return clsColumnSchema.enDataType.String;
            }

            // Calculate confidence percentages
            if ((double)boolCount / nonEmptyCount >= Threshold)
                return clsColumnSchema.enDataType.Boolean;

            if ((double)intCount / nonEmptyCount >= Threshold)
                return clsColumnSchema.enDataType.Integer;

            if ((double)doubleCount / nonEmptyCount >= Threshold)
                return clsColumnSchema.enDataType.Double;

            if ((double)dateTimeCount / nonEmptyCount >= Threshold)
                return clsColumnSchema.enDataType.DateTime;

            // If no specific type meets the 80% threshold, fallback to String
            return clsColumnSchema.enDataType.String;
        }

        static public clsSchema GenerateSchema(ref List<List<string>> list)
        {
            clsSchema tableSchema = new clsSchema();
            if (list == null || list.Count == 0) return null;

            // Assuming the first row contains headers
            List<string> headers = list[0];

            for (int columnIndex = 0; columnIndex < headers.Count; columnIndex++)
            {
                string columnName = headers[columnIndex].Trim();

                // Extract a single column using LINQ
                // skip headers
                int currentColumnIndex = columnIndex;  
                var columnData = list.Skip(1).Select(row => row.Count > currentColumnIndex ? row[currentColumnIndex] : null);

                // Now we simply pass our single column pipeline into the method
                var dataType = GenerateColumnDataType(columnData);
                
                tableSchema.AddColumn(new clsColumnSchema(columnName, dataType));
            }

            // Remove the header row from the original list since it's now represented in the schema

            list.RemoveAt(0);

            return tableSchema;
        }
    }
}