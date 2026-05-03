        namespace Data_Clean_Tool.Controls
{
    partial class ctrDataGrid
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tcMain = new Guna.UI2.WinForms.Guna2TabControl();
            tabData = new TabPage();
            llCleaning = new Guna.UI2.WinForms.Guna2HtmlLabel();
            gridData = new Guna.UI2.WinForms.Guna2DataGridView();
            pnlTopAction = new Guna.UI2.WinForms.Guna2Panel();
            btndown = new Guna.UI2.WinForms.Guna2Button();
            btnRight = new Guna.UI2.WinForms.Guna2Button();
            btnUp = new Guna.UI2.WinForms.Guna2Button();
            btnLeft = new Guna.UI2.WinForms.Guna2Button();
            tabDetails = new TabPage();
            tcMain.SuspendLayout();
            tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridData).BeginInit();
            pnlTopAction.SuspendLayout();
            SuspendLayout();
            // 
            // tcMain
            // 
            tcMain.Controls.Add(tabData);
            tcMain.Controls.Add(tabDetails);
            tcMain.Dock = DockStyle.Fill;
            tcMain.ItemSize = new Size(100, 30);
            tcMain.Location = new Point(0, 0);
            tcMain.Margin = new Padding(3, 4, 3, 4);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(640, 520);
            tcMain.TabButtonHoverState.BorderColor = Color.Empty;
            tcMain.TabButtonHoverState.FillColor = Color.FromArgb(50, 50, 50);
            tcMain.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 9F);
            tcMain.TabButtonHoverState.ForeColor = Color.White;
            tcMain.TabButtonHoverState.InnerColor = Color.FromArgb(50, 50, 50);
            tcMain.TabButtonIdleState.BorderColor = Color.Empty;
            tcMain.TabButtonIdleState.FillColor = Color.FromArgb(35, 35, 35);
            tcMain.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 9F);
            tcMain.TabButtonIdleState.ForeColor = Color.LightGray;
            tcMain.TabButtonIdleState.InnerColor = Color.FromArgb(35, 35, 35);
            tcMain.TabButtonSelectedState.BorderColor = Color.Empty;
            tcMain.TabButtonSelectedState.FillColor = Color.FromArgb(40, 40, 40);
            tcMain.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 9F);
            tcMain.TabButtonSelectedState.ForeColor = Color.White;
            tcMain.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            tcMain.TabButtonSize = new Size(100, 30);
            tcMain.TabIndex = 0;
            tcMain.TabMenuBackColor = Color.FromArgb(30, 30, 30);
            tcMain.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabData
            // 
            tabData.BackColor = Color.FromArgb(35, 35, 35);
            tabData.Controls.Add(llCleaning);
            tabData.Controls.Add(gridData);
            tabData.Controls.Add(pnlTopAction);
            tabData.Location = new Point(4, 34);
            tabData.Margin = new Padding(3, 4, 3, 4);
            tabData.Name = "tabData";
            tabData.Padding = new Padding(3, 4, 3, 4);
            tabData.Size = new Size(632, 482);
            tabData.TabIndex = 0;
            tabData.Text = "Data";
            // 
            // llCleaning
            // 
            llCleaning.BackColor = Color.Transparent;
            llCleaning.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llCleaning.ForeColor = Color.FromArgb(140, 100, 180);
            llCleaning.Location = new Point(166, 194);
            llCleaning.Name = "llCleaning";
            llCleaning.Size = new Size(286, 61);
            llCleaning.TabIndex = 3;
            llCleaning.Text = "Cleaning Data";
            // 
            // gridData
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 40);
            gridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            gridData.BackgroundColor = Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridData.ColumnHeadersHeight = 30;
            gridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(76, 132, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridData.DefaultCellStyle = dataGridViewCellStyle3;
            gridData.Dock = DockStyle.Fill;
            gridData.GridColor = Color.FromArgb(50, 50, 50);
            gridData.Location = new Point(3, 57);
            gridData.Margin = new Padding(3, 4, 3, 4);
            gridData.Name = "gridData";
            gridData.ReadOnly = true;
            gridData.RowHeadersVisible = false;
            gridData.RowHeadersWidth = 51;
            gridData.RowTemplate.Height = 25;
            gridData.Size = new Size(626, 421);
            gridData.TabIndex = 1;
            gridData.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(40, 40, 40);
            gridData.ThemeStyle.AlternatingRowsStyle.Font = null;
            gridData.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gridData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gridData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gridData.ThemeStyle.BackColor = Color.FromArgb(35, 35, 35);
            gridData.ThemeStyle.GridColor = Color.FromArgb(50, 50, 50);
            gridData.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(50, 50, 50);
            gridData.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gridData.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            gridData.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gridData.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridData.ThemeStyle.HeaderStyle.Height = 30;
            gridData.ThemeStyle.ReadOnly = true;
            gridData.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(45, 45, 45);
            gridData.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridData.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            gridData.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            gridData.ThemeStyle.RowsStyle.Height = 25;
            gridData.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(76, 132, 255);
            gridData.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            gridData.CellContentClick += gridData_CellContentClick;
            // 
            // pnlTopAction
            // 
            pnlTopAction.Controls.Add(btndown);
            pnlTopAction.Controls.Add(btnRight);
            pnlTopAction.Controls.Add(btnUp);
            pnlTopAction.Controls.Add(btnLeft);
            pnlTopAction.CustomizableEdges = customizableEdges9;
            pnlTopAction.Dock = DockStyle.Top;
            pnlTopAction.Location = new Point(3, 4);
            pnlTopAction.Margin = new Padding(3, 4, 3, 4);
            pnlTopAction.Name = "pnlTopAction";
            pnlTopAction.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlTopAction.Size = new Size(626, 53);
            pnlTopAction.TabIndex = 2;
            pnlTopAction.Paint += pnlTopAction_Paint;
            // 
            // btndown
            // 
            btndown.BackgroundImage = Properties.Resources.arrow_fat_down;
            btndown.BackgroundImageLayout = ImageLayout.Stretch;
            btndown.BorderColor = Color.Gray;
            btndown.BorderThickness = 1;
            btndown.CustomizableEdges = customizableEdges1;
            btndown.FillColor = Color.FromArgb(45, 45, 45);
            btndown.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndown.ForeColor = SystemColors.WindowFrame;
            btndown.Image = Properties.Resources.arrow_down;
            btndown.ImageSize = new Size(30, 30);
            btndown.IndicateFocus = true;
            btndown.Location = new Point(481, 9);
            btndown.Margin = new Padding(3, 4, 3, 4);
            btndown.Name = "btndown";
            btndown.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btndown.Size = new Size(32, 33);
            btndown.TabIndex = 8;
            btndown.Click += btndown_Click;
            // 
            // btnRight
            // 
            btnRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRight.BackgroundImage = Properties.Resources.arrow_up;
            btnRight.BorderColor = Color.Gray;
            btnRight.BorderThickness = 1;
            btnRight.CustomizableEdges = customizableEdges3;
            btnRight.FillColor = Color.FromArgb(45, 45, 45);
            btnRight.Font = new Font("Segoe UI", 9F);
            btnRight.ForeColor = Color.White;
            btnRight.Image = Properties.Resources.arrow_right;
            btnRight.ImageSize = new Size(30, 30);
            btnRight.Location = new Point(580, 9);
            btnRight.Margin = new Padding(3, 4, 3, 4);
            btnRight.Name = "btnRight";
            btnRight.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnRight.Size = new Size(32, 33);
            btnRight.TabIndex = 7;
            btnRight.Click += btnRight_Click;
            // 
            // btnUp
            // 
            btnUp.BackgroundImage = Properties.Resources.arrow_up;
            btnUp.BorderColor = Color.Gray;
            btnUp.BorderThickness = 1;
            btnUp.CustomizableEdges = customizableEdges5;
            btnUp.FillColor = Color.FromArgb(45, 45, 45);
            btnUp.Font = new Font("Segoe UI", 9F);
            btnUp.ForeColor = Color.White;
            btnUp.Image = Properties.Resources.arrow_up1;
            btnUp.ImageSize = new Size(30, 30);
            btnUp.Location = new Point(431, 9);
            btnUp.Margin = new Padding(3, 4, 3, 4);
            btnUp.Name = "btnUp";
            btnUp.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnUp.Size = new Size(32, 33);
            btnUp.TabIndex = 5;
            btnUp.Click += btnUp_Click_1;
            // 
            // btnLeft
            // 
            btnLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLeft.BackgroundImage = Properties.Resources.arrow_up;
            btnLeft.BorderColor = Color.Gray;
            btnLeft.BorderThickness = 1;
            btnLeft.CustomizableEdges = customizableEdges7;
            btnLeft.FillColor = Color.FromArgb(45, 45, 45);
            btnLeft.Font = new Font("Segoe UI", 9F);
            btnLeft.ForeColor = Color.White;
            btnLeft.Image = Properties.Resources.arrow_left;
            btnLeft.ImageSize = new Size(30, 30);
            btnLeft.Location = new Point(532, 9);
            btnLeft.Margin = new Padding(3, 4, 3, 4);
            btnLeft.Name = "btnLeft";
            btnLeft.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnLeft.Size = new Size(32, 33);
            btnLeft.TabIndex = 6;
            btnLeft.Click += btnLeft_Click;
            // 
            // tabDetails
            // 
            tabDetails.BackColor = Color.FromArgb(35, 35, 35);
            tabDetails.Location = new Point(4, 34);
            tabDetails.Margin = new Padding(3, 4, 3, 4);
            tabDetails.Name = "tabDetails";
            tabDetails.Padding = new Padding(3, 4, 3, 4);
            tabDetails.Size = new Size(632, 482);
            tabDetails.TabIndex = 1;
            tabDetails.Text = "Details";
            // 
            // ctrDataGrid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            Controls.Add(tcMain);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ctrDataGrid";
            Size = new Size(640, 520);
            tcMain.ResumeLayout(false);
            tabData.ResumeLayout(false);
            tabData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridData).EndInit();
            pnlTopAction.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcMain;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TabPage tabDetails;
        private Guna.UI2.WinForms.Guna2DataGridView gridData;
        private Guna.UI2.WinForms.Guna2Panel pnlTopAction;
        private Guna.UI2.WinForms.Guna2Button btnRight;
        private Guna.UI2.WinForms.Guna2Button btnUp;
        private Guna.UI2.WinForms.Guna2Button btnLeft;
        private Guna.UI2.WinForms.Guna2Button btndown;
        private Guna.UI2.WinForms.Guna2HtmlLabel llCleaning;
    }
}
