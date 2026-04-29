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
        void MakeButtonsVisible()
        {
            llCleaningOption.Enabled = true;
                llCleaningOption.Visible = true;
                llOutput.Enabled = true;
                llOutput.Visible = true;
            btnFromClipboard.Enabled = true;
            btnFromClipboard.Visible = true;
            btnRemoveDuplicateRows.Enabled = true;
            btnRemoveDuplicateRows.Visible = true;
            btnReplaceNULL.Enabled = true;
            btnReplaceNULL.Visible = true;
            btnStanderizeCasing.Enabled = true;
            btnStanderizeCasing.Visible = true;
            btnToFile.Enabled = true;
            btnToFile.Visible = true;
        }

        private async void btnFromFile_Click(object sender, EventArgs e)
        {
            string FilePath = Utility.clsUtility.GetExcelOrCsvPath();

            if (!File.Exists(FilePath))
                return;

            MakeButtonsVisible();
            pRightPanel.Enabled = true;
            pRightPanel.Visible = true;
            _Config.FilePathwithFileName = FilePath;
            ctrTableInfo1.SetTableInfo(_Config);

            try
            {
                // 2. Push the heavy synchronous work to a background thread
                await Task.Run(() =>
                {
                    _clean = new clsClean(_Config);
                    

                });
                ctrDataGrid1.LoadData(_clean);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(ctrDataGrid1.HasData)
             {
                MakeButtonsVisible();
            }
        }
    }
}