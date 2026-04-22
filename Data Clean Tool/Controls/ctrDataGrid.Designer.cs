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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tcMain = new Guna.UI2.WinForms.Guna2TabControl();
            tabData = new TabPage();
            gridData = new Guna.UI2.WinForms.Guna2DataGridView();
            pnlTopAction = new Guna.UI2.WinForms.Guna2Panel();
            pnlNav = new Guna.UI2.WinForms.Guna2Panel();
            btnRight = new Guna.UI2.WinForms.Guna2Button();
            btnLeft = new Guna.UI2.WinForms.Guna2Button();
            btnDown = new Guna.UI2.WinForms.Guna2Button();
            btnUp = new Guna.UI2.WinForms.Guna2Button();
            tabDetails = new TabPage();
            tcMain.SuspendLayout();
            tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridData).BeginInit();
            pnlNav.SuspendLayout();
            SuspendLayout();
            // 
            // tcMain
            // 
            tcMain.Controls.Add(tabData);
            tcMain.Controls.Add(tabDetails);
            tcMain.Dock = DockStyle.Fill;
            tcMain.ItemSize = new Size(100, 30);
            tcMain.Location = new Point(0, 0);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(560, 390);
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
            tabData.Controls.Add(gridData);
            tabData.Controls.Add(pnlTopAction);
            tabData.Controls.Add(pnlNav);
            tabData.Location = new Point(4, 34);
            tabData.Name = "tabData";
            tabData.Padding = new Padding(3);
            tabData.Size = new Size(552, 352);
            tabData.TabIndex = 0;
            tabData.Text = "Data";
            // 
            // gridData
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 40);
            gridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridData.BackgroundColor = Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
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
            gridData.Location = new Point(3, 43);
            gridData.Name = "gridData";
            gridData.RowHeadersVisible = false;
            gridData.Size = new Size(546, 266);
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
            gridData.ThemeStyle.ReadOnly = false;
            gridData.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(45, 45, 45);
            gridData.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridData.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            gridData.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            gridData.ThemeStyle.RowsStyle.Height = 25;
            gridData.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(76, 132, 255);
            gridData.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // pnlTopAction
            // 
            pnlTopAction.CustomizableEdges = customizableEdges1;
            pnlTopAction.Dock = DockStyle.Top;
            pnlTopAction.Location = new Point(3, 3);
            pnlTopAction.Name = "pnlTopAction";
            pnlTopAction.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlTopAction.Size = new Size(546, 40);
            pnlTopAction.TabIndex = 2;
            // 
            // pnlNav
            // 
            pnlNav.Controls.Add(btnRight);
            pnlNav.Controls.Add(btnLeft);
            pnlNav.Controls.Add(btnDown);
            pnlNav.Controls.Add(btnUp);
            pnlNav.CustomizableEdges = customizableEdges11;
            pnlNav.Dock = DockStyle.Bottom;
            pnlNav.Location = new Point(3, 309);
            pnlNav.Name = "pnlNav";
            pnlNav.ShadowDecoration.CustomizableEdges = customizableEdges12;
            pnlNav.Size = new Size(546, 40);
            pnlNav.TabIndex = 0;
            // 
            // btnRight
            // 
            btnRight.BorderColor = Color.Gray;
            btnRight.BorderThickness = 1;
            btnRight.CustomizableEdges = customizableEdges3;
            btnRight.FillColor = Color.FromArgb(45, 45, 45);
            btnRight.Font = new Font("Segoe UI", 9F);
            btnRight.ForeColor = Color.White;
            btnRight.Location = new Point(466, 5);
            btnRight.Name = "btnRight";
            btnRight.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnRight.Size = new Size(80, 30);
            btnRight.TabIndex = 3;
            btnRight.Text = "Right →";
            // 
            // btnLeft
            // 
            btnLeft.BorderColor = Color.Gray;
            btnLeft.BorderThickness = 1;
            btnLeft.CustomizableEdges = customizableEdges5;
            btnLeft.FillColor = Color.FromArgb(45, 45, 45);
            btnLeft.Font = new Font("Segoe UI", 9F);
            btnLeft.ForeColor = Color.White;
            btnLeft.Location = new Point(376, 5);
            btnLeft.Name = "btnLeft";
            btnLeft.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLeft.Size = new Size(80, 30);
            btnLeft.TabIndex = 2;
            btnLeft.Text = "← Left";
            // 
            // btnDown
            // 
            btnDown.BorderColor = Color.Gray;
            btnDown.BorderThickness = 1;
            btnDown.CustomizableEdges = customizableEdges7;
            btnDown.FillColor = Color.FromArgb(45, 45, 45);
            btnDown.Font = new Font("Segoe UI", 9F);
            btnDown.ForeColor = Color.White;
            btnDown.Location = new Point(181, 5);
            btnDown.Name = "btnDown";
            btnDown.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnDown.Size = new Size(80, 30);
            btnDown.TabIndex = 1;
            btnDown.Text = "Down ↓";
            // 
            // btnUp
            // 
            btnUp.BorderColor = Color.Gray;
            btnUp.BorderThickness = 1;
            btnUp.CustomizableEdges = customizableEdges9;
            btnUp.FillColor = Color.FromArgb(45, 45, 45);
            btnUp.Font = new Font("Segoe UI", 9F);
            btnUp.ForeColor = Color.White;
            btnUp.Location = new Point(91, 5);
            btnUp.Name = "btnUp";
            btnUp.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnUp.Size = new Size(80, 30);
            btnUp.TabIndex = 0;
            btnUp.Text = "↑ Up";
            // 
            // tabDetails
            // 
            tabDetails.BackColor = Color.FromArgb(35, 35, 35);
            tabDetails.Location = new Point(4, 34);
            tabDetails.Name = "tabDetails";
            tabDetails.Padding = new Padding(3);
            tabDetails.Size = new Size(472, 216);
            tabDetails.TabIndex = 1;
            tabDetails.Text = "Details";
            // 
            // ctrDataGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            Controls.Add(tcMain);
            Font = new Font("Segoe UI", 9F);
            Name = "ctrDataGrid";
            Size = new Size(560, 390);
            tcMain.ResumeLayout(false);
            tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridData).EndInit();
            pnlNav.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcMain;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TabPage tabDetails;
        private Guna.UI2.WinForms.Guna2DataGridView gridData;
        private Guna.UI2.WinForms.Guna2Panel pnlTopAction;
        private Guna.UI2.WinForms.Guna2Panel pnlNav;
        private Guna.UI2.WinForms.Guna2Button btnUp;
        private Guna.UI2.WinForms.Guna2Button btnRight;
        private Guna.UI2.WinForms.Guna2Button btnLeft;
        private Guna.UI2.WinForms.Guna2Button btnDown;
    }
}
