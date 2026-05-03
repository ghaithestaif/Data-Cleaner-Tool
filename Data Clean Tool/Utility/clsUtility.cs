using Cleaning_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Clean_Tool.Utility
{
    public class clsUtility
    {
        static public DataTable ConvertListToDataTable(IReadOnlyList<List<string>> data, clsSchema TableSchema)
        {
            DataTable table = new DataTable();
            if (data == null || data.Count == 0) return table;

            // Find the maximum number of columns across all rows to prevent out of bounds errors
            int maxColumns = TableSchema.NumberOfColumns;

            for (int i = 0; i < maxColumns; i++)
            {
                var columnSchema = TableSchema.GetColumnByIndex(i);

                string baseName = columnSchema.ColumnName;
                string columnName = baseName;
                int counter = 1;

                while (table.Columns.Contains(columnName))
                {
                    columnName = $"{baseName}_{counter}";
                    counter++;
                }

                table.Columns.Add(columnName, typeof(string));
            }



            // Create the columns in the DataTable


            // Fill the data
            foreach (var row in data)
            {
                object[] rowData = new object[maxColumns];
                for (int i = 0; i < row.Count; i++)
                {
                    rowData[i] = row[i];
                }
                table.Rows.Add(rowData);
            }

            return table;
        }


        public static string GetExcelOrCsvPath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Initial directory (optional)
                openFileDialog.InitialDirectory = "D:\\";

                // Set the filter for Excel and CSV files
                // Format: "Description|*.ext1;*.ext2|Next Description|*.ext3"
                openFileDialog.Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls|CSV Files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Return the path of specified file
                    return openFileDialog.FileName;
                }
            }

            return null;
        }
    }
}
