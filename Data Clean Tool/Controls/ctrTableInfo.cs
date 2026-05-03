using Cleaning_Layer;
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

namespace Data_Clean_Tool.Controls
{
    public partial class ctrTableInfo : UserControl
    {
        clsConfiguration _Config;
        public class TableInfoChangedEventArgs : EventArgs
        {
            public clsConfiguration Configuration { get; }
            public bool IsNewFile { get; }

            public TableInfoChangedEventArgs(bool isnew,clsConfiguration configuration)
            {
                Configuration = configuration;
                IsNewFile = isnew;
            }
        }

        public event EventHandler<TableInfoChangedEventArgs> TableInfoChanged;

        public ctrTableInfo()
        {
            InitializeComponent();
        }

        private void ctrTableInfo_Load(object sender, EventArgs e)
        {

        }

        protected virtual void OnTableInfoChanged(clsConfiguration configuration, bool isNewFile = false)
        {
            TableInfoChanged?.Invoke(this, new TableInfoChangedEventArgs(isNewFile, configuration));
        }

        public void SetTableInfo(clsConfiguration Config)
        {
            nudIgnoreRows.Text = $"First {nudIgnoreRows.Value} row(s)";
            if (Config != null)
            {
                txtFileBox.Text = Config.FilePathwithFileName;
                txtTitle.Text = Config.FileName?.ToString();
                llFileType.Text = Config.Extension?.ToString();
                btnSheetName.Text = Config.SheetName?.ToString();
                _Config = Config;
            }
        }

        private void nudIgnoreRows_ValueChanged(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text = $"First {nudIgnoreRows.Value} row(s)";
            _Config.NumberOfIgnoredRows = (int)nudIgnoreRows.Value;
            OnTableInfoChanged(_Config);
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            string FilePath = Utility.clsUtility.GetExcelOrCsvPath();
            if (!string.IsNullOrEmpty(FilePath))
            {
                clsConfiguration Config = new clsConfiguration
                {
                    FilePathwithFileName = FilePath,
                };
                _Config = Config;
                OnTableInfoChanged(Config, true);

            }

        }

        private void chkHasHeader_CheckedChanged(object sender, EventArgs e)
        {

            //implementation






           // OnTableInfoChanged(_Config);
        }
    }
}
