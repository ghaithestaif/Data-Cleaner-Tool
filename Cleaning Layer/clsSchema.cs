using System;
using System.Collections.Generic;
using System.Data.Common;
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
          // newColumn.ColumnIndex = _columns.Count; // Set the column index based on current count
            _columns.Add(newColumn);
        }
        public clsColumnSchema GetColumnByID(int ID)
        {
            var column = _columns.FirstOrDefault(c => c.ID == ID);
            if (column == null)
            {
                throw new IndexOutOfRangeException($"ID {ID} is out of range.");
            }
            return column;
        }
        
         public clsColumnSchema GetColumnByIndex(int index)
        {
            if (index < 0 || index >= _columns.Count)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range.");
            }
            return _columns[index];
        }
        public void DeleteColumn(int index)
        {
            if (index < 0 || index >= _columns.Count)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range.");
            }
         //   EditIndex(index);
            _columns.RemoveAt(index);
            
        }
        //private void EditIndex(int ColumnIndex)
        //{
        //    for (int i = ColumnIndex + 1; i < _columns.Count; i++)
        //    {
        //        _columns.ElementAt(i).ColumnIndex--;
        //    }
        //}



        public void DeleteColumnByName(string columnName)
        {
            var column = _columns.FirstOrDefault(c => c.ColumnName.Equals(columnName, StringComparison.OrdinalIgnoreCase));
            if (column == null)
            {
                throw new ArgumentException($"Column with name '{columnName}' was not found.");
            }
         //   EditIndex(column.ColumnIndex);
            _columns.Remove(column);
        }
        public void DeleteColumnByID(int ID)
        {
            var column = _columns.FirstOrDefault(c => c.ID == ID);
            if (column == null)
            {
                throw new IndexOutOfRangeException($"ID {ID} is out of range.");
            }
         //   EditIndex(column.ColumnIndex);
            _columns.Remove(column);
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