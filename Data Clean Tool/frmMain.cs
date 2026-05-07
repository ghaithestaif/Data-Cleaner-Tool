using Cleaning_Layer;
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
                ctrDataGrid1.Subscribe(_clean);
                ctrTableInfo1.Subscribe(_clean);
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
            btnToFolder.Visible= true;
            btnToFolder.Enabled = true;
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


        async void _StartCleaning()
        {
            ctrDataGrid1.status = enStatus.Cleaning;
            try
            {
                // 2. Push the heavy synchronous work to a background thread
                await Task.Run(() =>
                {
                    _clean.Clean();
                });

                // Show the cleaning summary report when done
                
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

                // Show the cleaning summary report when done
                
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

        private void btnRemoveDuplicateRows_Click(object sender, EventArgs e)
        {
            //show a dialog 
            if (MessageBox.Show("This will remove duplicate rows based on all columns. Do you want to continue?", "Confirm Remove Duplicates", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _Config.RemoveDuplicates = true;
            }

        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            ctrDataGrid1.status = Data_Clean_Tool.Controls.ctrDataGrid.enStatus.Cleaning;

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

        private void btnToFile_Click(object sender, EventArgs e)
        {
            string outputPath = Utility.clsUtility.GetExcelOrCsvPath();
            if(outputPath == null|| !File.Exists(outputPath))
                return;

            if (_Config.Extension == ".xlsx")
            {
                clsImportExportServices.ExportToExcel(_clean.ReadOnlyData, outputPath, _Config.SheetName);

            }
            else if (_Config.Extension==".csv")
            {
                clsImportExportServices.ExportToCsv(_clean.ReadOnlyData, outputPath);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string outputPath = Utility.clsUtility.GetExcelOrCsvPath(true);
            if (outputPath == null && !File.Exists(outputPath))
                return;

            if (_Config.Extension == ".xlsx")
            {
                clsImportExportServices.ExportToExcel(_clean.ReadOnlyData, outputPath, _Config.SheetName);

            }
            else if (_Config.Extension == ".csv")
            {
                clsImportExportServices.ExportToCsv(_clean.ReadOnlyData, outputPath);
            }

        }
    }
}