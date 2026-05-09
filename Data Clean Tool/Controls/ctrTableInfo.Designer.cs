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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            lblFile = new Label();
            txtFileBox = new Guna.UI2.WinForms.Guna2TextBox();
            btnBrowseFile = new Guna.UI2.WinForms.Guna2Button();
            lblType = new Label();
            lblAlias = new Label();
            txtAlias = new Guna.UI2.WinForms.Guna2TextBox();
            llFileType = new Guna.UI2.WinForms.Guna2TextBox();
            btnSheetName = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label1 = new Label();
            gbReport = new Guna.UI2.WinForms.Guna2GroupBox();
            btnMoreReportInfo = new Guna.UI2.WinForms.Guna2Button();
            llAffectedRows = new Label();
            label7 = new Label();
            llUpdatedRows = new Label();
            label5 = new Label();
            llRemovedRows = new Label();
            btnIgnoreRows = new Guna.UI2.WinForms.Guna2Button();
            gbReport.SuspendLayout();
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
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.ForeColor = Color.LightGray;
            lblFile.Location = new Point(3, 80);
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
            txtFileBox.Location = new Point(118, 80);
            txtFileBox.Margin = new Padding(3, 5, 3, 5);
            txtFileBox.Name = "txtFileBox";
            txtFileBox.PlaceholderText = "";
            txtFileBox.ReadOnly = true;
            txtFileBox.SelectedText = "";
            txtFileBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtFileBox.Size = new Size(472, 35);
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
            btnBrowseFile.Location = new Point(596, 80);
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
            lblType.Location = new Point(3, 129);
            lblType.Name = "lblType";
            lblType.Size = new Size(43, 20);
            lblType.TabIndex = 5;
            lblType.Text = "Type:";
            // 
            // lblAlias
            // 
            lblAlias.AutoSize = true;
            lblAlias.ForeColor = Color.LightGray;
            lblAlias.Location = new Point(2, 178);
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
            txtAlias.Location = new Point(117, 178);
            txtAlias.Margin = new Padding(3, 5, 3, 5);
            txtAlias.Name = "txtAlias";
            txtAlias.PlaceholderText = "";
            txtAlias.ReadOnly = true;
            txtAlias.SelectedText = "";
            txtAlias.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtAlias.Size = new Size(497, 35);
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
            llFileType.Location = new Point(118, 129);
            llFileType.Margin = new Padding(3, 5, 3, 5);
            llFileType.Name = "llFileType";
            llFileType.PlaceholderText = "";
            llFileType.ReadOnly = true;
            llFileType.SelectedText = "";
            llFileType.ShadowDecoration.CustomizableEdges = customizableEdges10;
            llFileType.Size = new Size(497, 35);
            llFileType.TabIndex = 27;
            // 
            // btnSheetName
            // 
            btnSheetName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSheetName.BorderColor = Color.FromArgb(60, 60, 60);
            btnSheetName.Cursor = Cursors.IBeam;
            btnSheetName.CustomizableEdges = customizableEdges11;
            btnSheetName.DefaultText = "??";
            btnSheetName.FillColor = Color.FromArgb(40, 40, 40);
            btnSheetName.Font = new Font("Segoe UI", 9F);
            btnSheetName.ForeColor = Color.White;
            btnSheetName.Location = new Point(117, 227);
            btnSheetName.Margin = new Padding(3, 5, 3, 5);
            btnSheetName.Name = "btnSheetName";
            btnSheetName.PlaceholderText = "";
            btnSheetName.ReadOnly = true;
            btnSheetName.SelectedText = "";
            btnSheetName.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnSheetName.Size = new Size(497, 35);
            btnSheetName.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(2, 227);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 32;
            label2.Text = "Sheet Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(10, 58);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 34;
            label1.Text = "Removed Rows:";
            // 
            // gbReport
            // 
            gbReport.BorderColor = Color.DimGray;
            gbReport.Controls.Add(btnMoreReportInfo);
            gbReport.Controls.Add(llAffectedRows);
            gbReport.Controls.Add(label7);
            gbReport.Controls.Add(llUpdatedRows);
            gbReport.Controls.Add(label5);
            gbReport.Controls.Add(llRemovedRows);
            gbReport.Controls.Add(label1);
            gbReport.CustomBorderColor = Color.DimGray;
            gbReport.CustomizableEdges = customizableEdges15;
            gbReport.Dock = DockStyle.Bottom;
            gbReport.FillColor = Color.FromArgb(35, 35, 35);
            gbReport.Font = new Font("Segoe UI", 9F);
            gbReport.ForeColor = Color.White;
            gbReport.Location = new Point(0, 316);
            gbReport.Name = "gbReport";
            gbReport.ShadowDecoration.CustomizableEdges = customizableEdges16;
            gbReport.Size = new Size(640, 96);
            gbReport.TabIndex = 35;
            gbReport.Text = "Report";
            // 
            // btnMoreReportInfo
            // 
            btnMoreReportInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMoreReportInfo.BorderColor = Color.Gray;
            btnMoreReportInfo.BorderThickness = 1;
            btnMoreReportInfo.CustomizableEdges = customizableEdges13;
            btnMoreReportInfo.FillColor = Color.FromArgb(45, 45, 45);
            btnMoreReportInfo.Font = new Font("Segoe UI", 9F);
            btnMoreReportInfo.ForeColor = Color.White;
            btnMoreReportInfo.Location = new Point(532, 0);
            btnMoreReportInfo.Margin = new Padding(3, 4, 3, 4);
            btnMoreReportInfo.Name = "btnMoreReportInfo";
            btnMoreReportInfo.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnMoreReportInfo.Size = new Size(108, 40);
            btnMoreReportInfo.TabIndex = 36;
            btnMoreReportInfo.Text = "More Info";
            btnMoreReportInfo.Click += btnMoreReportInfo_Click;
            // 
            // llAffectedRows
            // 
            llAffectedRows.AutoSize = true;
            llAffectedRows.ForeColor = Color.LightGray;
            llAffectedRows.Location = new Point(471, 58);
            llAffectedRows.Name = "llAffectedRows";
            llAffectedRows.Size = new Size(23, 20);
            llAffectedRows.TabIndex = 40;
            llAffectedRows.Text = "??";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(351, 58);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 39;
            label7.Text = "Affected Rows:";
            // 
            // llUpdatedRows
            // 
            llUpdatedRows.AutoSize = true;
            llUpdatedRows.ForeColor = Color.LightGray;
            llUpdatedRows.Location = new Point(295, 58);
            llUpdatedRows.Name = "llUpdatedRows";
            llUpdatedRows.Size = new Size(23, 20);
            llUpdatedRows.TabIndex = 38;
            llUpdatedRows.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(175, 58);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 37;
            label5.Text = "Updated Rows:";
            // 
            // llRemovedRows
            // 
            llRemovedRows.AutoSize = true;
            llRemovedRows.ForeColor = Color.LightGray;
            llRemovedRows.Location = new Point(130, 58);
            llRemovedRows.Name = "llRemovedRows";
            llRemovedRows.Size = new Size(23, 20);
            llRemovedRows.TabIndex = 36;
            llRemovedRows.Text = "??";
            // 
            // btnIgnoreRows
            // 
            btnIgnoreRows.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIgnoreRows.BorderColor = Color.Gray;
            btnIgnoreRows.BorderThickness = 1;
            btnIgnoreRows.CustomizableEdges = customizableEdges17;
            btnIgnoreRows.FillColor = Color.FromArgb(45, 45, 45);
            btnIgnoreRows.Font = new Font("Segoe UI", 9F);
            btnIgnoreRows.ForeColor = Color.White;
            btnIgnoreRows.Location = new Point(118, 271);
            btnIgnoreRows.Margin = new Padding(3, 4, 3, 4);
            btnIgnoreRows.Name = "btnIgnoreRows";
            btnIgnoreRows.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnIgnoreRows.Size = new Size(200, 32);
            btnIgnoreRows.TabIndex = 41;
            btnIgnoreRows.Text = "Ignore Rows";
            btnIgnoreRows.Click += btnIgnoreRows_Click;
            // 
            // ctrTableInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            Controls.Add(btnIgnoreRows);
            Controls.Add(gbReport);
            Controls.Add(btnSheetName);
            Controls.Add(label2);
            Controls.Add(llFileType);
            Controls.Add(txtAlias);
            Controls.Add(lblAlias);
            Controls.Add(lblType);
            Controls.Add(btnBrowseFile);
            Controls.Add(txtFileBox);
            Controls.Add(lblFile);
            Controls.Add(txtTitle);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ctrTableInfo";
            Size = new Size(640, 412);
            Load += ctrTableInfo_Load;
            gbReport.ResumeLayout(false);
            gbReport.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private System.Windows.Forms.Label lblFile;
        private Guna.UI2.WinForms.Guna2TextBox txtFileBox;
        private Guna.UI2.WinForms.Guna2Button btnBrowseFile;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAlias;
        private Guna.UI2.WinForms.Guna2TextBox txtAlias;
        private Guna.UI2.WinForms.Guna2TextBox llFileType;
        private Guna.UI2.WinForms.Guna2TextBox btnSheetName;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox gbReport;
        private Label llAffectedRows;
        private Label label7;
        private Label llUpdatedRows;
        private Label label5;
        private Label llRemovedRows;
        private Guna.UI2.WinForms.Guna2Button btnMoreReportInfo;
        private Guna.UI2.WinForms.Guna2Button btnIgnoreRows;
    }
}
