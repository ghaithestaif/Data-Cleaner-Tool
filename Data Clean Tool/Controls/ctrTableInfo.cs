using Cleaning_Layer;
using Cleaning_Layer.Report_Classes;
using Data_Clean_Tool.Features;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Data_Clean_Tool.Controls.ctrDataGrid;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Data_Clean_Tool.Controls
{
    public partial class ctrTableInfo : UserControl
    {
        
        public class TableInfoChangedEventArgs : EventArgs
        {

            public string FilePath;
            public TableInfoChangedEventArgs(string FilePath)
            {
                this.FilePath = FilePath;
            }
        }

        public event EventHandler<TableInfoChangedEventArgs> TableInfoChanged;

        public class IgnoreRowsSelectedEventArgs : EventArgs
        {
            public int NumberOfRows { get; }
            public IgnoreRowsSelectedEventArgs(int NumberOfRows)
            {
                this.NumberOfRows = NumberOfRows;
            }
        }

        public event EventHandler<IgnoreRowsSelectedEventArgs> IgnoreRowsSelected;


        public ctrTableInfo()
        {
            InitializeComponent();
        }
        private void Clean_DataUpdated(object sender, clsClean.DataUpdatedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => Clean_DataUpdated(sender, e)));
                return;
            }

            if (e.Data == null || e.Schema == null)
            {
                MessageBox.Show("No data to load.");
                return;
            }
            if (e.FeaturesReports == null)
                return;
            // Update the UI with the new data, schema, and feature reports

            
            llAffectedRows.Text = $"{e.FeaturesReports.Sum(f => f.RecordsAffected)}";
            llRemovedRows.Text = $"{e.FeaturesReports.Where(f => f.RemovedRecordsAffected > 0).Sum(f => f.RemovedRecordsAffected)}";
            llUpdatedRows.Text = $"{e.FeaturesReports.Where(f => f.UpdatedRecordsAffected > 0).Sum(f => f.UpdatedRecordsAffected)}";


        }

        public void Subscribe(clsClean clean)
        {
            clean.DataUpdated += Clean_DataUpdated;
        }

        private void ctrTableInfo_Load(object sender, EventArgs e)
        {

        }

        protected virtual void OnTableInfoChanged(string filePath)
        {
            TableInfoChanged?.Invoke(this, new TableInfoChangedEventArgs(filePath));
        }
        protected virtual void OnIgnoreRowsSelected(int numberOfRows)
        {
            IgnoreRowsSelected?.Invoke(this, new IgnoreRowsSelectedEventArgs(numberOfRows));
        }

        public void SetTableInfo(clsConfiguration Config)
        {
            if (Config != null)
            {
                txtFileBox.Text = Config.FilePathwithFileName;
                txtTitle.Text = Config.FileName?.ToString();
                llFileType.Text = Config.Extension?.ToString();
                btnSheetName.Text = Config.SheetName?.ToString();
                llAffectedRows.Text = "0";
                llRemovedRows.Text = "0";
                llUpdatedRows.Text = "0";
            }
        }



        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            string FilePath = Utility.clsUtility.GetExcelOrCsvPath();
            if (!File.Exists(FilePath))
            {
                MessageBox.Show("Please select a valid file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(FilePath))
            {
           
                OnTableInfoChanged(FilePath);
            }

        }

        private void btnMoreReportInfo_Click(object sender, EventArgs e)
        {
            Data_Clean_Tool.frmReport frm = new Data_Clean_Tool.frmReport();
            frm.ShowDialog();
        }

        private void gbReport_Click(object sender, EventArgs e)
        {

        }

        private void btnIgnoreRows_Click(object sender, EventArgs e)
        {
            frmRowsIgnore frm = new frmRowsIgnore();
            frm.ShowDialog();


            if(frm.selectedRowCount > 0)
            {
                OnIgnoreRowsSelected(frm.selectedRowCount);
            }

        }
    }
}
