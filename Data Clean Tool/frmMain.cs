using Cleaning_Layer;
using Data_Clean_Tool.Utility;
using Guna.UI2.WinForms;
using System.Drawing;
using System.IO;
using System.Web;
using System.Windows.Forms;

namespace Data_Clean_Tool
{
    public partial class frmMain : Form
    {
        clsClean _clean;
        clsConfiguration _Config = new clsConfiguration();
        private List<string> _loadedSheetNames = new List<string>();

        public frmMain()
        {
            InitializeComponent();
        }

        

        private void LoadSheets(Dictionary<int, string> sheetNames)
        {
            _loadedSheetNames = sheetNames?.Values.ToList() ?? new List<string>();

            if (sheetFlowPanel != null)
            {
                sheetFlowPanel.SuspendLayout();
                sheetFlowPanel.Controls.Clear();

                foreach (string sheetName in _loadedSheetNames)
                {
                    var card = new Data_Clean_Tool.Controls.ctrSheetCard(sheetName);
                    card.SheetSelected += OnSheetSelected;
                    sheetFlowPanel.Controls.Add(card);
                }

                sheetFlowPanel.ResumeLayout();
            }
        }
        
        private async void OnSheetSelected(string sheetName)
        {
            int sheetIndex = _loadedSheetNames.IndexOf(sheetName) + 1;

            if (_Config.SheetNumber == sheetIndex)
            {
                return; // No change in sheet selection
            }
            if (string.IsNullOrWhiteSpace(sheetName))
            {
                return;
            }
            if (sheetIndex <= 0)
            {
                return;
            }


            _Config.SheetName = sheetName;
            _Config.SheetNumber = sheetIndex;

            if (_clean == null)
            {
                _clean = new clsClean(_Config);
            }
            else
            {
                _clean.UpdateConfig(_Config);

            }
            ctrDataGrid1.status = Data_Clean_Tool.Controls.ctrDataGrid.enStatus.loading;

            try
            {
                await System.Threading.Tasks.Task.Run(() =>
                {
                    _clean.ExtractData(_Config.SheetNumber);
                });
            }
            catch (System.Exception ex)
            {
                Data_Clean_Tool.Utility.ErrorLogger.LogError(ex, "Error occurred while selecting a sheet.");
              MessageBox.Show("An error occurred. Check the Windows Event Log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ctrDataGrid1.LoadData(_clean);
            ctrTableInfo1.SetTableInfo(_Config);
            
        }

        void MakeButtonsVisible()
        {
            pRightPanel.Enabled = true;
            pRightPanel.Visible = true;
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

        void _HandleSheets(string FilePath)
        {
            Dictionary<int, string> sheetNames = clsImportServices.GetExcelSheetNames(FilePath);
            LoadSheets(sheetNames);

            if (sheetNames.Count > 0)
            {
                OnSheetSelected(sheetNames[0]);
            }

        }

        
        async void _StartCleaning()
        {
            try
            {
                // 2. Push the heavy synchronous work to a background thread
                await Task.Run(() =>
                {
                    _clean.Clean();
                });

                ctrDataGrid1.LoadData(_clean);
            }
            catch (Exception ex)
            {
                Utility.ErrorLogger.LogError(ex, "Error occurred while cleaning data.");
                MessageBox.Show("An error occurred. Check the Windows Event Log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void btnFromFile_Click_1(object sender, EventArgs e)
        {

            string FilePath = Utility.clsUtility.GetExcelOrCsvPath();
            if (!File.Exists(FilePath))
                return;

            MakeButtonsVisible();
            _Config.FilePathwithFileName = FilePath;
            _HandleSheets(FilePath);
            //    _LoadFormData(FilePath);
        }


        

        private void frmMain_Load(object sender, EventArgs e)
        {

        }



        private async void ctrTableInfo1_TableInfoChanged(object sender, Data_Clean_Tool.Controls.ctrTableInfo.TableInfoChangedEventArgs e)
        {
            if (e.IsNewFile)
            {

                _Config = e.Configuration;
                _clean.UpdateConfig(_Config);
                ctrDataGrid1.status = Data_Clean_Tool.Controls.ctrDataGrid.enStatus.loading;
                _HandleSheets(_Config.FilePathwithFileName);
                await Task.Run(() =>
                {
                    try
                    {
                        _clean.ExtractData(_Config.SheetNumber);
                    }
                    catch (Exception ex)
                    {
                        // This runs on background thread - need to marshal back to UI
                        this.Invoke((MethodInvoker)delegate
                        {
                            ErrorLogger.LogError(ex, "Background processing error");
                            MessageBox.Show("Error processing data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        });
                    }
                });


                ctrDataGrid1.LoadData(_clean);

            }
            else
            {
                _Config = e.Configuration;
                _clean.UpdateConfig(_Config);
                _StartCleaning();


            }
            if (ctrDataGrid1.HasData)
            {
                MakeButtonsVisible();
            }
        }

        private void btnFromClipboard_Click(object sender, EventArgs e)
        {

        }

    }
}