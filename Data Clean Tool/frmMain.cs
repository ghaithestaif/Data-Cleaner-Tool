using Cleaning_Layer;
using Cleaning_Layer.Report_Classes;
using Data_Clean_Tool.Features;
using Data_Clean_Tool.Utility;
using DocumentFormat.OpenXml.Math;
using Guna.UI2.WinForms;
using System.Drawing;
using System.IO;
using System.Web;
using System.Windows.Forms;
using static Data_Clean_Tool.Controls.ctrDataGrid;

namespace Data_Clean_Tool
{
    public partial class frmMain : Form
    {
        clsClean _clean;
        clsConfiguration _Config;
        private List<string> _loadedSheetNames = new List<string>();
        
        public frmMain()
        {
            InitializeComponent();
        }
        enum enStatus
        {
            NoData,
            Loading,
            Ready,
            Cleaning
        }
        enStatus _currentStatus = enStatus.NoData;
        enStatus currStatus
        {
            get { return _currentStatus; }
            set
            {
                _currentStatus = value;
                switch (_currentStatus)
                {
                    case enStatus.NoData:
                        HandleCleaningLoadingButtons(true);
                        break;
                    case enStatus.Loading:
                        HandleCleaningLoadingButtons(false);
                        break;
                    case enStatus.Ready:
                        HandleCleaningLoadingButtons(true);
                        break;
                    case enStatus.Cleaning:
                        HandleCleaningLoadingButtons(false);
                        break;
                }
            }
        }
        void HandleCleaningLoadingButtons(bool enable)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => HandleCleaningLoadingButtons(enable)));
                return;
            }

            openNewFileToolStripMenuItem.Enabled = enable;
            exportToFileToolStripMenuItem.Enabled = enable;
            exportToFolderToolStripMenuItem.Enabled = enable;
            startCleaningToolStripMenuItem.Enabled = enable;
            showReportToolStripMenuItem.Enabled = enable;
            showTableToolStripMenuItem.Enabled = enable;
            btnStart.Enabled = enable;
            btnExport.Enabled = enable;
            btnFromFile.Enabled = enable;
            btnOpenFile.Enabled = enable;
            btnSave.Enabled = enable;
            btnSaveAs.Enabled = enable;
        }

        private bool EnsureConfigInitialized()
        {
            if (_Config != null)
            {
                return true;
            }

            MessageBox.Show("Please open a file first.", "No File Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
        private bool ValidateCleanObject()
        {
            if (_clean != null)
            {
                return true;
            }
            MessageBox.Show("Please select a sheet to clean.", "No Sheet Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
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
        void DataUpdated(object sender, clsClean.DataUpdatedEventArgs e) {
            currStatus = enStatus.Ready;
        }

        private async void OnSheetSelected(string sheetName)
        {



            clsFeatureReportManager.reset();

            if (!EnsureConfigInitialized())
            {
                return;
            }

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
                _clean.DataUpdated += DataUpdated;
                ctrDataGrid1.Subscribe(_clean);
                ctrTableInfo1.Subscribe(_clean);
            }

            else
            {
                _clean.UpdateConfig(_Config);

            }
            ctrDataGrid1.status = Data_Clean_Tool.Controls.ctrDataGrid.enStatus.loading;
            currStatus = enStatus.Loading;
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
                        Data_Clean_Tool.Utility.ErrorLogger.LogError(ex, "Error occurred while selecting a sheet.");
                        MessageBox.Show("An error occurred. Check the Windows Event Log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }
            });

        }

        void MakeButtonsVisible()
        {
            pRightPanel.Enabled = true;
            pRightPanel.Visible = true;
            llCleaningOption.Enabled = true;
            llCleaningOption.Visible = true;
            llOutput.Enabled = true;
            llOutput.Visible = true;
            btnRemoveDuplicateRows.Enabled = true;
            btnRemoveDuplicateRows.Visible = true;
            btnReplaceNULL.Enabled = true;
            btnReplaceNULL.Visible = true;
            btnStanderizeCasing.Enabled = true;
            btnStanderizeCasing.Visible = true;
            btnSave.Enabled = true;
            btnSave.Visible = true;
            btnSaveAs.Visible = true;
            btnSaveAs.Enabled = true;
            btnStart.Enabled = true;
            btnStart.Visible = true;
            btnExport.Enabled = true;
            btnExport.Visible = true;
        }

        void _HandleSheets(string FilePath)
        {
            Dictionary<int, string> sheetNames = clsImportExportServices.GetExcelSheetNames(FilePath);
            LoadSheets(sheetNames);

            if (sheetNames.Count > 0)
            {
                OnSheetSelected(sheetNames[0]);
            }

        }
        private void btnFromFile_Click_1(object sender, EventArgs e)
        {
            string FilePath = Utility.clsUtility.GetExcelOrCsvPath();
            if (!File.Exists(FilePath))
                return;


            clsFeatureReportManager.reset();
            _Config = new clsConfiguration();
            MakeButtonsVisible();
            
            _Config.FilePathwithFileName = FilePath;
            _HandleSheets(FilePath);
        }




        private void frmMain_Load(object sender, EventArgs e)
        {

        }



        private async void ctrTableInfo1_TableInfoChanged(object sender, Data_Clean_Tool.Controls.ctrTableInfo.TableInfoChangedEventArgs e)
        {

            ctrDataGrid1.status = Data_Clean_Tool.Controls.ctrDataGrid.enStatus.loading;
            currStatus = enStatus.Loading;
            _Config = new clsConfiguration();
            
            _Config.FilePathwithFileName = e.FilePath;
            _HandleSheets(_Config.FilePathwithFileName);
            clsFeatureReportManager.reset();

            if (ctrDataGrid1.HasData)
            {
                MakeButtonsVisible();
            }
        }



        private void btnRemoveDuplicateRows_Click(object sender, EventArgs e)
        {
            if (!EnsureConfigInitialized())
            {
                return;
            }

            //show a dialog 
            if (MessageBox.Show("This will remove duplicate rows based on all columns. Do you want to continue?", "Confirm Remove Duplicates", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _Config.RemoveDuplicates = true;
            }

        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (!EnsureConfigInitialized() || !ValidateCleanObject())
            {
                return;
            }

            ctrDataGrid1.status = Data_Clean_Tool.Controls.ctrDataGrid.enStatus.Cleaning;
            currStatus = enStatus.Cleaning;
            await Task.Run(() =>
            {
                try
                {
                    _clean.Clean();
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
            
        }

        private void btnReplaceNULL_Click(object sender, EventArgs e)
        {
            if (!EnsureConfigInitialized())
            {
                return;
            }

            // Pass in your existing _Config or a new one
            using (frmEmptyNullReplace frm = new frmEmptyNullReplace())
            {
                // Check if the user clicked the Confirm/Save button
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // You can now access the returned option directly!

                    _Config.HandleMissingValues = true;
                    _Config.ReplaceOption = frm.SelectedOption;

                    // Also _Config.ReplaceOption will already be updated if you need the entire object.

                    // Execute further data cleaning code here...
                    _clean.UpdateConfig(_Config);
                }
            }
        }

        private void btnStanderizeCasing_Click(object sender, EventArgs e)
        {
            if (!EnsureConfigInitialized())
            {
                return;
            }

            using (frmStanderizeCase frm = new frmStanderizeCase())
            {
                // Check if the user clicked the Confirm/Save button
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // You can now access the returned option directly!

                    _Config.StandardizeData = true;
                    _Config.StanderdizeDataOption = frm.SelectedOption;


                    _clean.UpdateConfig(_Config);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!EnsureConfigInitialized() || !ValidateCleanObject())
            {
                return;
            }

            if (_Config.FilePathwithFileName == null || !File.Exists(_Config.FilePathwithFileName))
            {
                return;
            }

            clsImportExportServices.ExportData(_clean.ReadOnlyData, _Config.FilePathwithFileName, _Config.SheetName);
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (!EnsureConfigInitialized() || !ValidateCleanObject())
            {
                return;
            }

            string outputPath = Utility.clsUtility.GetExcelOrCsvPath(true);
            if (string.IsNullOrWhiteSpace(outputPath))
                return;

            clsImportExportServices.ExportData(_clean.ReadOnlyData, outputPath, _Config.SheetName);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.O))
            {
                btnFromFile_Click_1(null, null);
                return true;
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                btnSave_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void resetCleaningOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EnsureConfigInitialized())
            {
                return;
            }

            _Config.resetCleaningOptions();
        }
        private void openNewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFromFile_Click_1(null, null);
        }

        private void exportToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave_Click(null, null);


        }

        private void exportToFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            btnSaveAs_Click(null, null);
        }

        private void ignoreRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EnsureConfigInitialized())
            {
                return;
            }

            frmRowsIgnore frm = new frmRowsIgnore();
            frm.ShowDialog();


            if (frm.selectedRowCount > 0)
            {
                MessageBox.Show($"{frm.selectedRowCount} rows will be removed in the cleaning process.", "Rows Ignored", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Config.NumberOfIgnoredRows = frm.selectedRowCount;

            }


        }

        private void replaceNullEmptyValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnReplaceNULL_Click(null, null);
        }

        private void standardizeCasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStanderizeCasing_Click(null, null);
        }

        private void removeDuplicateRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRemoveDuplicateRows_Click(null, null);
        }

        private void startCleaningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStart_Click(null, null);
        }

        private void showReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.ShowDialog();
        }

        

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            btnFromFile_Click_1(null, null);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            btnSave_Click(null, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
        private void ctrTableInfo1_IgnoreRowsSelected(object sender, Data_Clean_Tool.Controls.ctrTableInfo.IgnoreRowsSelectedEventArgs e)
        {
           _Config.NumberOfIgnoredRows = e.NumberOfRows;

        }
    }
}