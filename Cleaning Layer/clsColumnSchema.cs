using System;

namespace Cleaning_Layer
{
    /// <summary>
    /// Represents the schema and metadata for a single column in the dataset.
    /// </summary>
    public class clsColumnSchema
    {
        public enum enDataType
        {
            String,
            Integer,
            Double,
            Boolean,
            DateTime
        }
        public string DefaultValue
        {
            get
            {
                return DataType switch
                {
                    enDataType.String => "N/A",
                    enDataType.Integer => "0",
                    enDataType.Double => "0.0",
                    enDataType.Boolean => "false",
                    enDataType.DateTime => DateTime.MinValue.ToString("o"), // ISO 8601 format
                    _ => "N/A"
                };
            }
        }

        // Properties have private/internal setters to prevent accidental corruption

        static int columnCounter = 1; // Static counter to assign unique column indices
       public int ID = columnCounter++; // Unique identifier for each column schema instance

        public string ColumnName { get; private set; }
     //  public int ColumnIndex; // Expose the unique column index as a read-only property
        public enDataType DataType { get; internal set; }
        public bool IsNullable { get; private set; }

        public clsColumnSchema( string columnName, enDataType dataType, bool isNullable)
        {
            ColumnName = columnName;
            DataType = dataType;
            IsNullable = isNullable;
        }
    }
}
