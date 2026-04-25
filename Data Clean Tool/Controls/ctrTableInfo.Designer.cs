namespace Data_Clean_Tool.Controls
{
    // Explicitly inheriting from UserControl fixes the Dispose and Controls errors
    partial class ctrTableInfo : System.Windows.Forms.UserControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            lblIconInfo = new Label();
            lblFile = new Label();
            txtFileBox = new Guna.UI2.WinForms.Guna2TextBox();
            btnBrowseFile = new Guna.UI2.WinForms.Guna2Button();
            lblType = new Label();
            lblIgnore = new Label();
            chkHasHeader = new Guna.UI2.WinForms.Guna2CheckBox();
            lblAlias = new Label();
            txtAlias = new Guna.UI2.WinForms.Guna2TextBox();
            llFileType = new Guna.UI2.WinForms.Guna2TextBox();
            nudIgnoreRows = new Guna.UI2.WinForms.Guna2NumericUpDown();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)nudIgnoreRows).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.BorderColor = Color.Fuchsia;
            txtTitle.BorderThickness = 2;
            txtTitle.Cursor = Cursors.IBeam;
            txtTitle.CustomizableEdges = customizableEdges1;
            txtTitle.DefaultText = "my.xlsx[Sheet1]";
            txtTitle.FillColor = Color.FromArgb(40, 40, 40);
            txtTitle.Font = new Font("Segoe UI", 9F);
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(11, 13);
            txtTitle.Margin = new Padding(3, 5, 3, 5);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "";
            txtTitle.SelectedText = "";
            txtTitle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTitle.Size = new Size(520, 40);
            txtTitle.TabIndex = 0;
            // 
            // lblIconInfo
            // 
            lblIconInfo.AutoSize = true;
            lblIconInfo.ForeColor = Color.LightGray;
            lblIconInfo.Location = new Point(11, 73);
            lblIconInfo.Name = "lblIconInfo";
            lblIconInfo.Size = new Size(128, 20);
            lblIconInfo.TabIndex = 1;
            lblIconInfo.Text = "(?) Input from file.";
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.ForeColor = Color.LightGray;
            lblFile.Location = new Point(11, 127);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(35, 20);
            lblFile.TabIndex = 2;
            lblFile.Text = "File:";
            // 
            // txtFileBox
            // 
            txtFileBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFileBox.BorderColor = Color.FromArgb(60, 60, 60);
            txtFileBox.Cursor = Cursors.IBeam;
            txtFileBox.CustomizableEdges = customizableEdges3;
            txtFileBox.DefaultText = "D:\\Users\\Desktop\\my.xlsx[Sheet1]";
            txtFileBox.FillColor = Color.FromArgb(40, 40, 40);
            txtFileBox.Font = new Font("Segoe UI", 9F);
            txtFileBox.ForeColor = Color.White;
            txtFileBox.Location = new Point(126, 120);
            txtFileBox.Margin = new Padding(3, 5, 3, 5);
            txtFileBox.Name = "txtFileBox";
            txtFileBox.PlaceholderText = "";
            txtFileBox.ReadOnly = true;
            txtFileBox.SelectedText = "";
            txtFileBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtFileBox.Size = new Size(464, 35);
            txtFileBox.TabIndex = 3;
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseFile.BorderColor = Color.Gray;
            btnBrowseFile.BorderThickness = 1;
            btnBrowseFile.CustomizableEdges = customizableEdges5;
            btnBrowseFile.FillColor = Color.FromArgb(45, 45, 45);
            btnBrowseFile.Font = new Font("Segoe UI", 9F);
            btnBrowseFile.ForeColor = Color.White;
            btnBrowseFile.Location = new Point(597, 120);
            btnBrowseFile.Margin = new Padding(3, 4, 3, 4);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnBrowseFile.Size = new Size(40, 35);
            btnBrowseFile.TabIndex = 4;
            btnBrowseFile.Text = "...";
            btnBrowseFile.Click += btnBrowseFile_Click;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.ForeColor = Color.LightGray;
            lblType.Location = new Point(11, 195);
            lblType.Name = "lblType";
            lblType.Size = new Size(43, 20);
            lblType.TabIndex = 5;
            lblType.Text = "Type:";
            // 
            // lblIgnore
            // 
            lblIgnore.AutoSize = true;
            lblIgnore.ForeColor = Color.LightGray;
            lblIgnore.Location = new Point(10, 235);
            lblIgnore.Name = "lblIgnore";
            lblIgnore.Size = new Size(55, 20);
            lblIgnore.TabIndex = 7;
            lblIgnore.Text = "Ignore:";
            // 
            // chkHasHeader
            // 
            chkHasHeader.AutoSize = true;
            chkHasHeader.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkHasHeader.CheckedState.BorderRadius = 0;
            chkHasHeader.CheckedState.BorderThickness = 0;
            chkHasHeader.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkHasHeader.ForeColor = Color.LightGray;
            chkHasHeader.Location = new Point(125, 368);
            chkHasHeader.Margin = new Padding(3, 4, 3, 4);
            chkHasHeader.Name = "chkHasHeader";
            chkHasHeader.Size = new Size(103, 24);
            chkHasHeader.TabIndex = 9;
            chkHasHeader.Text = "has header";
            chkHasHeader.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkHasHeader.UncheckedState.BorderRadius = 0;
            chkHasHeader.UncheckedState.BorderThickness = 0;
            chkHasHeader.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            chkHasHeader.CheckedChanged += chkHasHeader_CheckedChanged;
            // 
            // lblAlias
            // 
            lblAlias.AutoSize = true;
            lblAlias.ForeColor = Color.LightGray;
            lblAlias.Location = new Point(10, 331);
            lblAlias.Name = "lblAlias";
            lblAlias.Size = new Size(44, 20);
            lblAlias.TabIndex = 25;
            lblAlias.Text = "Alias:";
            // 
            // txtAlias
            // 
            txtAlias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAlias.BorderColor = Color.FromArgb(60, 60, 60);
            txtAlias.Cursor = Cursors.IBeam;
            txtAlias.CustomizableEdges = customizableEdges7;
            txtAlias.DefaultText = "my";
            txtAlias.FillColor = Color.FromArgb(40, 40, 40);
            txtAlias.Font = new Font("Segoe UI", 9F);
            txtAlias.ForeColor = Color.White;
            txtAlias.Location = new Point(125, 324);
            txtAlias.Margin = new Padding(3, 5, 3, 5);
            txtAlias.Name = "txtAlias";
            txtAlias.PlaceholderText = "";
            txtAlias.ReadOnly = true;
            txtAlias.SelectedText = "";
            txtAlias.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtAlias.Size = new Size(498, 35);
            txtAlias.TabIndex = 26;
            // 
            // llFileType
            // 
            llFileType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            llFileType.BorderColor = Color.FromArgb(60, 60, 60);
            llFileType.Cursor = Cursors.IBeam;
            llFileType.CustomizableEdges = customizableEdges9;
            llFileType.DefaultText = "Excel XLSX";
            llFileType.FillColor = Color.FromArgb(40, 40, 40);
            llFileType.Font = new Font("Segoe UI", 9F);
            llFileType.ForeColor = Color.White;
            llFileType.Location = new Point(126, 191);
            llFileType.Margin = new Padding(3, 5, 3, 5);
            llFileType.Name = "llFileType";
            llFileType.PlaceholderText = "";
            llFileType.ReadOnly = true;
            llFileType.SelectedText = "";
            llFileType.ShadowDecoration.CustomizableEdges = customizableEdges10;
            llFileType.Size = new Size(497, 35);
            llFileType.TabIndex = 27;
            // 
            // nudIgnoreRows
            // 
            nudIgnoreRows.BackColor = Color.Turquoise;
            nudIgnoreRows.BorderColor = Color.FromArgb(60, 60, 60);
            nudIgnoreRows.BorderRadius = 1;
            nudIgnoreRows.CustomizableEdges = customizableEdges11;
            nudIgnoreRows.FillColor = Color.FromArgb(40, 40, 40);
            nudIgnoreRows.Font = new Font("Segoe UI", 9F);
            nudIgnoreRows.Location = new Point(125, 252);
            nudIgnoreRows.Margin = new Padding(3, 4, 3, 4);
            nudIgnoreRows.Name = "nudIgnoreRows";
            nudIgnoreRows.ShadowDecoration.CustomizableEdges = customizableEdges12;
            nudIgnoreRows.Size = new Size(498, 36);
            nudIgnoreRows.TabIndex = 28;
            nudIgnoreRows.UpDownButtonFillColor = Color.FromArgb(70, 75, 80);
            nudIgnoreRows.UpDownButtonForeColor = Color.Black;
            nudIgnoreRows.ValueChanged += nudIgnoreRows_ValueChanged;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.FromArgb(40, 40, 40);
            guna2HtmlLabel1.Font = new Font("Segoe UI", 10.2F);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(126, 263);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(102, 25);
            guna2HtmlLabel1.TabIndex = 29;
            guna2HtmlLabel1.Text = "First 0 Row(s)";
            // 
            // ctrTableInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(nudIgnoreRows);
            Controls.Add(llFileType);
            Controls.Add(txtAlias);
            Controls.Add(lblAlias);
            Controls.Add(chkHasHeader);
            Controls.Add(lblIgnore);
            Controls.Add(lblType);
            Controls.Add(btnBrowseFile);
            Controls.Add(txtFileBox);
            Controls.Add(lblFile);
            Controls.Add(lblIconInfo);
            Controls.Add(txtTitle);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ctrTableInfo";
            Size = new Size(640, 412);
            Load += ctrTableInfo_Load;
            ((System.ComponentModel.ISupportInitialize)nudIgnoreRows).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private System.Windows.Forms.Label lblIconInfo;
        private System.Windows.Forms.Label lblFile;
        private Guna.UI2.WinForms.Guna2TextBox txtFileBox;
        private Guna.UI2.WinForms.Guna2Button btnBrowseFile;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblIgnore;
        private Guna.UI2.WinForms.Guna2CheckBox chkHasHeader;
        private System.Windows.Forms.Label lblAlias;
        private Guna.UI2.WinForms.Guna2TextBox txtAlias;
        private Guna.UI2.WinForms.Guna2TextBox llFileType;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudIgnoreRows;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
