using System;
using System.Collections.Generic;
using System.Linq;

namespace Cleaning_Layer
{
    /// <summary>
    /// Represents the full schema of the dataset, acting as a container and manager for all column schemas.
    /// </summary>
    public class clsSchema
    {
        private List<clsColumnSchema> _columns = new List<clsColumnSchema>();

        // Exposes the count easily
        public int NumberOfColumns => _columns.Count;

        // Exposes columns for reading/iterating without allowing external code to add/remove items
        public IReadOnlyList<clsColumnSchema> Columns => _columns.AsReadOnly();

        public void AddColumn(clsColumnSchema newColumn)
        {
            if (newColumn == null) throw new ArgumentNullException(nameof(newColumn));
            _columns.Add(newColumn);
        }

        public clsColumnSchema GetColumnByIndex(int index)
        {
            if (index < 0 || index >= _columns.Count)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range.");
            }
            return _columns[index];
        }

        // Added ability to find a column by name
        public clsColumnSchema GetColumnByName(string columnName)
        {
            var column = _columns.FirstOrDefault(c => c.ColumnName.Equals(columnName, StringComparison.OrdinalIgnoreCase));
            if (column == null)
            {
                throw new ArgumentException($"Column with name '{columnName}' was not found.");
            }
            return column;
        }

        public void ChangeDataType(int index, clsColumnSchema.enDataType newDataType)
        {
            if (index < 0 || index >= _columns.Count)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range.");
            }
            _columns[index].DataType = newDataType;
        }
    }
}