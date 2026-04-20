using System;
using System.Collections.Generic;

namespace Cleaning_Layer.Schema_Classes
{
    public class clsGenerateSchema
    {
        // A threshold of 0.8 means if 80% of the data matches a type, we assume that is the column's type.
        private const double CONFIDENCE_THRESHOLD = 0.80;

        static clsColumnSchema.enDataType GenerateColumnDataType(int columnIndex, List<List<string>> list)
        {
            int intCount = 0, doubleCount = 0, boolCount = 0, dateTimeCount = 0, stringCount = 0;
            int nonEmptyCount = 0;

            // Start at i = 1 if list[0] contains your header names
            for (int i = 1; i < list.Count; i++)
            {
                if (columnIndex >= list[i].Count) continue;

                string value = list[i][columnIndex]?.Trim();

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
            if ((double)boolCount / nonEmptyCount >= CONFIDENCE_THRESHOLD)
                return clsColumnSchema.enDataType.Boolean;

            if ((double)intCount / nonEmptyCount >= CONFIDENCE_THRESHOLD)
                return clsColumnSchema.enDataType.Integer;

            if ((double)doubleCount / nonEmptyCount >= CONFIDENCE_THRESHOLD)
                return clsColumnSchema.enDataType.Double;

            if ((double)dateTimeCount / nonEmptyCount >= CONFIDENCE_THRESHOLD)
                return clsColumnSchema.enDataType.DateTime;

            // If no specific type meets the 80% threshold, fallback to String
            return clsColumnSchema.enDataType.String;
        }

        static public clsSchema GenerateSchema(List<List<string>> list)
        {
            clsSchema tableSchema = new clsSchema();
            if (list == null || list.Count == 0) return null;
            // Assuming the first row contains headers
            List<string> headers = list[0];
            for (int columnIndex = 0; columnIndex < headers.Count; columnIndex++)
            {
                string columnName = headers[columnIndex].Trim();
                var dataType = GenerateColumnDataType(columnIndex, list);
                tableSchema.AddColumn(new clsColumnSchema(columnName, dataType));
            }

            return tableSchema;


        }
    }
}
