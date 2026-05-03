using System.Drawing;
using System.IO;
using System.Web;
using System.Windows.Forms;
using Cleaning_Layer;
using Guna.UI2.WinForms;

namespace Data_Clean_Tool
{
    public partial class frmMain : Form
    {
        clsClean _clean;
        clsConfiguration _Config = new clsConfiguration();

        private FlowLayoutPanel _sheetFlowPanel;
        private List<string> _loadedSheetNames = new List<string>();

        public frmMain()
        {
            InitializeComponent();
            InitializeSheetCanvas();
        }

        private void InitializeSheetCanvas()
        {
            if (_sheetFlowPanel != null)
            {
                return;
            }

            pnlCanvas.Controls.Clear();

            _sheetFlowPanel = new FlowLayoutPanel();
            _sheetFlowPanel.Dock = DockStyle.Fill;
            _sheetFlowPanel.AutoScroll = true;
            _sheetFlowPanel.WrapContents = true;
            _sheetFlowPanel.FlowDirection = FlowDirection.LeftToRight;
            _sheetFlowPanel.BackColor = Color.FromArgb(24, 24, 24);
            _sheetFlowPanel.Padding = new Padding(12);
            _sheetFlowPanel.Margin = new Padding(0);

            pnlCanvas.Controls.Add(_sheetFlowPanel);
        }

        private Guna2Panel CreateSheetCard(string sheetName)
        {
            Color baseColor = Color.FromArgb(40, 40, 40);
            Color hoverColor = Color.FromArgb(55, 55, 55);

            Guna2Panel card = new Guna2Panel();
            card.Size = new Size(160, 90);
            card.Margin = new Padding(10);
            card.BorderRadius = 14;
            card.FillColor = baseColor;
            card.BorderColor = Color.FromArgb(70, 70, 70);
            card.BorderThickness = 1;
            card.Cursor = Cursors.Hand;
            card.Tag = sheetName;

            Label title = new Label();
            title.Dock = DockStyle.Fill;
            title.Text = sheetName;
            title.ForeColor = Color.White;
            title.BackColor = Color.Transparent;
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.AutoEllipsis = true;
            title.Cursor = Cursors.Hand;

            card.Controls.Add(title);

            card.Click += delegate { OnSheetSelected(sheetName); };
            title.Click += delegate { OnSheetSelected(sheetName); };

            card.MouseEnter += delegate { card.FillColor = hoverColor; };
            card.MouseLeave += delegate { card.FillColor = baseColor; };
            title.MouseEnter += delegate { card.FillColor = hoverColor; };
            title.MouseLeave += delegate { card.FillColor = baseColor; };

            return card;
        }

        private void LoadSheets(Dictionary<int, string> sheetNames)
        {
            InitializeSheetCanvas();

            _loadedSheetNames = sheetNames?.Values.ToList() ?? new List<string>();
            _sheetFlowPanel.SuspendLayout();
            _sheetFlowPanel.Controls.Clear();

            foreach (string sheetName in _loadedSheetNames)
            {
                _sheetFlowPanel.Controls.Add(CreateSheetCard(sheetName));
            }

            _sheetFlowPanel.ResumeLayout();
        }

        private async void OnSheetSelected(string sheetName)
        {
            if (string.IsNullOrWhiteSpace(sheetName))
            {
                return;
            }

            int sheetIndex = _loadedSheetNames.IndexOf(sheetName) + 1;
            if (sheetIndex <= 0)
            {
                return;
            }

            try
            {
                _Config.SheetNumber = sheetIndex;

                if (_clean == null)
                {
                    _clean = new clsClean(_Config);
                }
                else
                {
                    _clean.UpdateConfig(_Config);

                }
                await System.Threading.Tasks.Task.Run(() =>
                  {
                    _clean.ExtractData(sheetIndex);
                });
                //  ctrTableInfo1.SetTableInfo(_Config);
                ctrDataGrid1.LoadData(_clean);
            }
            catch (System.Exception ex)
            {
                
                Data_Clean_Tool.Utility.ErrorLogger.LogError(ex, "Error occurred while selecting a sheet.");
              MessageBox.Show("An error occurred. Check the Windows Event Log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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

        async void _LoadFormData(string FilePath)
        {
            ctrTableInfo1.SetTableInfo(_Config);
            try
            {
                // 2. Push the heavy synchronous work to a background thread
                await Task.Run(() =>
                {
                    _clean.ExtractData(1);
                });

                ctrDataGrid1.LoadData(_clean);
                _HandleSheets(FilePath);

            }
            catch (Exception ex)
            {
                Utility.ErrorLogger.LogError(ex, "Error occurred while loading form data.");
                MessageBox.Show("An error occurred. Check the Windows Event Log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            _clean = new clsClean(_Config);
            _LoadFormData(FilePath);
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
                _HandleSheets(_Config.FilePathwithFileName);
                await Task.Run(() =>
                {
                    _clean.ExtractData(1);
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