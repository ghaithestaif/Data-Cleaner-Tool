using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Cleaning_Layer;
using Guna.UI2.WinForms;

namespace Data_Clean_Tool
{
    public partial class frmMain : Form
    {
        clsClean _clean;
        clsConfiguration _Config = new clsConfiguration();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFromFile_Click(object sender, EventArgs e)
        {
            string FilePath = Utility.clsUtility.GetExcelOrCsvPath();

            if (FilePath != null && File.Exists(FilePath))
            {
                pRightPanel.Enabled = true;
                pRightPanel.Visible = true;

                _Config.FilePathwithFileName = FilePath;
                ctrTableInfo1.SetTableInfo(_Config);

                _clean = new clsClean(_Config);
                ctrDataGrid1.LoadData(_clean);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void ctrDataGrid1_Load(object sender, EventArgs e)
        {

        }

        private void ctrTableInfo1_Load(object sender, EventArgs e)
        {

        }

        private void ctrTableInfo1_TableInfoChanged(object sender, Data_Clean_Tool.Controls.ctrTableInfo.TableInfoChangedEventArgs e)
        {
            if (!e.IsNewFile)
            {

                _Config = e.Configuration;
                _clean.UpdateConfig(_Config);
                _clean.Clean();
                ctrDataGrid1.LoadData(_clean);
            }
            else
            {
                _Config = e.Configuration;
                _clean = new clsClean(_Config);
                // _clean.Clean();
                ctrDataGrid1.LoadData(_clean);
            }
        }
    }
}