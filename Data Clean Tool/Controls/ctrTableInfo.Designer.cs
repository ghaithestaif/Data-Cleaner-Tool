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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            lblIconInfo = new Label();
            lblFile = new Label();
            txtFileBox = new Guna.UI2.WinForms.Guna2TextBox();
            btnBrowseFile = new Guna.UI2.WinForms.Guna2Button();
            lblType = new Label();
            lblIgnore = new Label();
            lblAlias = new Label();
            txtAlias = new Guna.UI2.WinForms.Guna2TextBox();
            llFileType = new Guna.UI2.WinForms.Guna2TextBox();
            nudIgnoreRows = new Guna.UI2.WinForms.Guna2NumericUpDown();
            btnSheetName = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
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
            txtTitle.CustomizableEdges = customizableEdges15;
            txtTitle.DefaultText = "my.xlsx[Sheet1]";
            txtTitle.FillColor = Color.FromArgb(40, 40, 40);
            txtTitle.Font = new Font("Segoe UI", 9F);
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(10, 10);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "";
            txtTitle.SelectedText = "";
            txtTitle.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtTitle.Size = new Size(455, 30);
            txtTitle.TabIndex = 0;
            // 
            // lblIconInfo
            // 
            lblIconInfo.AutoSize = true;
            lblIconInfo.ForeColor = Color.LightGray;
            lblIconInfo.Location = new Point(10, 55);
            lblIconInfo.Name = "lblIconInfo";
            lblIconInfo.Size = new Size(102, 15);
            lblIconInfo.TabIndex = 1;
            lblIconInfo.Text = "(?) Input from file.";
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.ForeColor = Color.LightGray;
            lblFile.Location = new Point(10, 90);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(28, 15);
            lblFile.TabIndex = 2;
            lblFile.Text = "File:";
            // 
            // txtFileBox
            // 
            txtFileBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFileBox.BorderColor = Color.FromArgb(60, 60, 60);
            txtFileBox.Cursor = Cursors.IBeam;
            txtFileBox.CustomizableEdges = customizableEdges17;
            txtFileBox.DefaultText = "D:\\Users\\Desktop\\my.xlsx[Sheet1]";
            txtFileBox.FillColor = Color.FromArgb(40, 40, 40);
            txtFileBox.Font = new Font("Segoe UI", 9F);
            txtFileBox.ForeColor = Color.White;
            txtFileBox.Location = new Point(110, 90);
            txtFileBox.Margin = new Padding(3, 4, 3, 4);
            txtFileBox.Name = "txtFileBox";
            txtFileBox.PlaceholderText = "";
            txtFileBox.ReadOnly = true;
            txtFileBox.SelectedText = "";
            txtFileBox.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtFileBox.Size = new Size(406, 26);
            txtFileBox.TabIndex = 3;
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseFile.BorderColor = Color.Gray;
            btnBrowseFile.BorderThickness = 1;
            btnBrowseFile.CustomizableEdges = customizableEdges19;
            btnBrowseFile.FillColor = Color.FromArgb(45, 45, 45);
            btnBrowseFile.Font = new Font("Segoe UI", 9F);
            btnBrowseFile.ForeColor = Color.White;
            btnBrowseFile.Location = new Point(522, 90);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnBrowseFile.Size = new Size(35, 26);
            btnBrowseFile.TabIndex = 4;
            btnBrowseFile.Text = "...";
            btnBrowseFile.Click += btnBrowseFile_Click;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.ForeColor = Color.LightGray;
            lblType.Location = new Point(10, 133);
            lblType.Name = "lblType";
            lblType.Size = new Size(35, 15);
            lblType.TabIndex = 5;
            lblType.Text = "Type:";
            // 
            // lblIgnore
            // 
            lblIgnore.AutoSize = true;
            lblIgnore.ForeColor = Color.LightGray;
            lblIgnore.Location = new Point(9, 176);
            lblIgnore.Name = "lblIgnore";
            lblIgnore.Size = new Size(44, 15);
            lblIgnore.TabIndex = 7;
            lblIgnore.Text = "Ignore:";
            // 
            // lblAlias
            // 
            lblAlias.AutoSize = true;
            lblAlias.ForeColor = Color.LightGray;
            lblAlias.Location = new Point(9, 219);
            lblAlias.Name = "lblAlias";
            lblAlias.Size = new Size(35, 15);
            lblAlias.TabIndex = 25;
            lblAlias.Text = "Alias:";
            // 
            // txtAlias
            // 
            txtAlias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAlias.BorderColor = Color.FromArgb(60, 60, 60);
            txtAlias.Cursor = Cursors.IBeam;
            txtAlias.CustomizableEdges = customizableEdges21;
            txtAlias.DefaultText = "my";
            txtAlias.FillColor = Color.FromArgb(40, 40, 40);
            txtAlias.Font = new Font("Segoe UI", 9F);
            txtAlias.ForeColor = Color.White;
            txtAlias.Location = new Point(109, 220);
            txtAlias.Margin = new Padding(3, 4, 3, 4);
            txtAlias.Name = "txtAlias";
            txtAlias.PlaceholderText = "";
            txtAlias.ReadOnly = true;
            txtAlias.SelectedText = "";
            txtAlias.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txtAlias.Size = new Size(436, 26);
            txtAlias.TabIndex = 26;
            // 
            // llFileType
            // 
            llFileType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            llFileType.BorderColor = Color.FromArgb(60, 60, 60);
            llFileType.Cursor = Cursors.IBeam;
            llFileType.CustomizableEdges = customizableEdges23;
            llFileType.DefaultText = "Excel XLSX";
            llFileType.FillColor = Color.FromArgb(40, 40, 40);
            llFileType.Font = new Font("Segoe UI", 9F);
            llFileType.ForeColor = Color.White;
            llFileType.Location = new Point(110, 133);
            llFileType.Margin = new Padding(3, 4, 3, 4);
            llFileType.Name = "llFileType";
            llFileType.PlaceholderText = "";
            llFileType.ReadOnly = true;
            llFileType.SelectedText = "";
            llFileType.ShadowDecoration.CustomizableEdges = customizableEdges24;
            llFileType.Size = new Size(435, 26);
            llFileType.TabIndex = 27;
            // 
            // nudIgnoreRows
            // 
            nudIgnoreRows.BackColor = Color.Turquoise;
            nudIgnoreRows.BorderColor = Color.FromArgb(60, 60, 60);
            nudIgnoreRows.BorderRadius = 1;
            nudIgnoreRows.CustomizableEdges = customizableEdges25;
            nudIgnoreRows.FillColor = Color.FromArgb(40, 40, 40);
            nudIgnoreRows.Font = new Font("Segoe UI", 9F);
            nudIgnoreRows.Location = new Point(109, 176);
            nudIgnoreRows.Name = "nudIgnoreRows";
            nudIgnoreRows.ShadowDecoration.CustomizableEdges = customizableEdges26;
            nudIgnoreRows.Size = new Size(436, 27);
            nudIgnoreRows.TabIndex = 28;
            nudIgnoreRows.UpDownButtonFillColor = Color.FromArgb(70, 75, 80);
            nudIgnoreRows.UpDownButtonForeColor = Color.Black;
            nudIgnoreRows.ValueChanged += nudIgnoreRows_ValueChanged;
            // 
            // btnSheetName
            // 
            btnSheetName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSheetName.BorderColor = Color.FromArgb(60, 60, 60);
            btnSheetName.Cursor = Cursors.IBeam;
            btnSheetName.CustomizableEdges = customizableEdges27;
            btnSheetName.DefaultText = "??";
            btnSheetName.FillColor = Color.FromArgb(40, 40, 40);
            btnSheetName.Font = new Font("Segoe UI", 9F);
            btnSheetName.ForeColor = Color.White;
            btnSheetName.Location = new Point(109, 263);
            btnSheetName.Margin = new Padding(3, 4, 3, 4);
            btnSheetName.Name = "btnSheetName";
            btnSheetName.PlaceholderText = "";
            btnSheetName.ReadOnly = true;
            btnSheetName.SelectedText = "";
            btnSheetName.ShadowDecoration.CustomizableEdges = customizableEdges28;
            btnSheetName.Size = new Size(436, 26);
            btnSheetName.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(10, 262);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 32;
            label2.Text = "Sheet Name";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.FromArgb(40, 40, 40);
            guna2HtmlLabel1.Font = new Font("Segoe UI", 10.2F);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(110, 176);
            guna2HtmlLabel1.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(85, 21);
            guna2HtmlLabel1.TabIndex = 34;
            guna2HtmlLabel1.Text = "First 0 Row(s)";
            // 
            // ctrTableInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btnSheetName);
            Controls.Add(label2);
            Controls.Add(nudIgnoreRows);
            Controls.Add(llFileType);
            Controls.Add(txtAlias);
            Controls.Add(lblAlias);
            Controls.Add(lblIgnore);
            Controls.Add(lblType);
            Controls.Add(btnBrowseFile);
            Controls.Add(txtFileBox);
            Controls.Add(lblFile);
            Controls.Add(lblIconInfo);
            Controls.Add(txtTitle);
            Font = new Font("Segoe UI", 9F);
            Name = "ctrTableInfo";
            Size = new Size(560, 309);
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
        private System.Windows.Forms.Label lblAlias;
        private Guna.UI2.WinForms.Guna2TextBox txtAlias;
        private Guna.UI2.WinForms.Guna2TextBox llFileType;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudIgnoreRows;
        private Guna.UI2.WinForms.Guna2TextBox btnSheetName;
        private Label label2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
