namespace Data_Clean_Tool
{
    partial class ctrTableInfo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIconInfo = new System.Windows.Forms.Label();

            // Labels
            this.lblFile = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblIgnore = new System.Windows.Forms.Label();
            this.lblUseSchema = new System.Windows.Forms.Label();
            this.lblWhitespace = new System.Windows.Forms.Label();
            this.lblIgnoreEmpty = new System.Windows.Forms.Label();
            this.lblIgnoreHidden = new System.Windows.Forms.Label();
            this.lblMetaInfo = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();

            // Inputs
            this.txtFileBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBrowseFile = new Guna.UI2.WinForms.Guna2Button();

            this.cmbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbIgnore = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chkHasHeader = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cmbSchema = new Guna.UI2.WinForms.Guna2ComboBox();

            this.chkTrim = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkSimplify = new Guna.UI2.WinForms.Guna2CheckBox();

            this.chkEmptyRows = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkEmptyCols = new Guna.UI2.WinForms.Guna2CheckBox();

            this.chkHiddenRows = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkHiddenCols = new Guna.UI2.WinForms.Guna2CheckBox();

            this.chkWatchFile = new Guna.UI2.WinForms.Guna2CheckBox();

            this.cmbMetaInfo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnBrowseMeta = new Guna.UI2.WinForms.Guna2Button();

            this.txtAlias = new Guna.UI2.WinForms.Guna2TextBox();

            this.SuspendLayout();

            // 
            // txtTitle
            // 
            this.txtTitle.BorderColor = System.Drawing.Color.Fuchsia; // Purple border
            this.txtTitle.BorderThickness = 2;
            this.txtTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(10, 10);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(460, 30);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "my.xlsx[Sheet1]";

            // 
            // lblIconInfo
            // 
            this.lblIconInfo.AutoSize = true;
            this.lblIconInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblIconInfo.Location = new System.Drawing.Point(10, 55);
            this.lblIconInfo.Name = "lblIconInfo";
            this.lblIconInfo.Size = new System.Drawing.Size(120, 15);
            this.lblIconInfo.TabIndex = 1;
            this.lblIconInfo.Text = "(?) Input from file.";

            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.ForeColor = System.Drawing.Color.LightGray;
            this.lblFile.Location = new System.Drawing.Point(10, 95);
            this.lblFile.Name = "lblFile";
            this.lblFile.Text = "File:";

            // txtFileBox
            this.txtFileBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtFileBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtFileBox.ForeColor = System.Drawing.Color.White;
            this.txtFileBox.Location = new System.Drawing.Point(110, 90);
            this.txtFileBox.Size = new System.Drawing.Size(420, 26);
            this.txtFileBox.Text = @"D:\Users\Desktop\my.xlsx[Sheet1]";

            // btnBrowseFile
            this.btnBrowseFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBrowseFile.BorderThickness = 1;
            this.btnBrowseFile.BorderColor = System.Drawing.Color.Gray;
            this.btnBrowseFile.ForeColor = System.Drawing.Color.White;
            this.btnBrowseFile.Location = new System.Drawing.Point(535, 90);
            this.btnBrowseFile.Size = new System.Drawing.Size(30, 26);
            this.btnBrowseFile.Text = "...";

            // lblType
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.Color.LightGray;
            this.lblType.Location = new System.Drawing.Point(10, 125);
            this.lblType.Text = "Type:";

            // cmbType
            this.cmbType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbType.ForeColor = System.Drawing.Color.White;
            this.cmbType.Location = new System.Drawing.Point(110, 120);
            this.cmbType.Size = new System.Drawing.Size(455, 26);
            this.cmbType.Items.Add("Excel XLSX");
            this.cmbType.SelectedIndex = 0;

            // lblIgnore
            this.lblIgnore.AutoSize = true;
            this.lblIgnore.ForeColor = System.Drawing.Color.LightGray;
            this.lblIgnore.Location = new System.Drawing.Point(10, 155);
            this.lblIgnore.Text = "Ignore:";

            // cmbIgnore
            this.cmbIgnore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbIgnore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbIgnore.ForeColor = System.Drawing.Color.White;
            this.cmbIgnore.Location = new System.Drawing.Point(110, 150);
            this.cmbIgnore.Size = new System.Drawing.Size(455, 26);
            this.cmbIgnore.Items.Add("First 0 row(s)");
            this.cmbIgnore.SelectedIndex = 0;

            // chkHasHeader
            this.chkHasHeader.AutoSize = true;
            this.chkHasHeader.ForeColor = System.Drawing.Color.LightGray;
            this.chkHasHeader.Location = new System.Drawing.Point(110, 180);
            this.chkHasHeader.Text = "has header";

            // lblUseSchema
            this.lblUseSchema.AutoSize = true;
            this.lblUseSchema.ForeColor = System.Drawing.Color.LightGray;
            this.lblUseSchema.Location = new System.Drawing.Point(10, 215);
            this.lblUseSchema.Text = "Use schema:";

            // cmbSchema
            this.cmbSchema.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbSchema.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbSchema.ForeColor = System.Drawing.Color.White;
            this.cmbSchema.Location = new System.Drawing.Point(110, 210);
            this.cmbSchema.Size = new System.Drawing.Size(455, 26);
            this.cmbSchema.Items.Add("No");
            this.cmbSchema.SelectedIndex = 0;

            // lblWhitespace
            this.lblWhitespace.AutoSize = true;
            this.lblWhitespace.ForeColor = System.Drawing.Color.LightGray;
            this.lblWhitespace.Location = new System.Drawing.Point(10, 245);
            this.lblWhitespace.Text = "Whitespace:";

            this.chkTrim.AutoSize = true;
            this.chkTrim.ForeColor = System.Drawing.Color.LightGray;
            this.chkTrim.Location = new System.Drawing.Point(110, 245);
            this.chkTrim.Text = "trim";

            this.chkSimplify.AutoSize = true;
            this.chkSimplify.ForeColor = System.Drawing.Color.LightGray;
            this.chkSimplify.Location = new System.Drawing.Point(320, 245);
            this.chkSimplify.Text = "simplify";

            // lblIgnoreEmpty
            this.lblIgnoreEmpty.AutoSize = true;
            this.lblIgnoreEmpty.ForeColor = System.Drawing.Color.LightGray;
            this.lblIgnoreEmpty.Location = new System.Drawing.Point(10, 275);
            this.lblIgnoreEmpty.Text = "Ignore empty:";

            this.chkEmptyRows.AutoSize = true;
            this.chkEmptyRows.ForeColor = System.Drawing.Color.LightGray;
            this.chkEmptyRows.Location = new System.Drawing.Point(110, 275);
            this.chkEmptyRows.Text = "rows";

            this.chkEmptyCols.AutoSize = true;
            this.chkEmptyCols.ForeColor = System.Drawing.Color.LightGray;
            this.chkEmptyCols.Location = new System.Drawing.Point(320, 275);
            this.chkEmptyCols.Text = "columns";

            // lblIgnoreHidden
            this.lblIgnoreHidden.AutoSize = true;
            this.lblIgnoreHidden.ForeColor = System.Drawing.Color.LightGray;
            this.lblIgnoreHidden.Location = new System.Drawing.Point(10, 305);
            this.lblIgnoreHidden.Text = "Ignore hidden:";

            this.chkHiddenRows.AutoSize = true;
            this.chkHiddenRows.ForeColor = System.Drawing.Color.LightGray;
            this.chkHiddenRows.Location = new System.Drawing.Point(110, 305);
            this.chkHiddenRows.Text = "rows";

            this.chkHiddenCols.AutoSize = true;
            this.chkHiddenCols.ForeColor = System.Drawing.Color.LightGray;
            this.chkHiddenCols.Location = new System.Drawing.Point(320, 305);
            this.chkHiddenCols.Text = "columns";

            // chkWatchFile
            this.chkWatchFile.AutoSize = true;
            this.chkWatchFile.ForeColor = System.Drawing.Color.LightGray;
            this.chkWatchFile.Location = new System.Drawing.Point(110, 335);
            this.chkWatchFile.Text = "watch file";

            // lblMetaInfo
            this.lblMetaInfo.AutoSize = true;
            this.lblMetaInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblMetaInfo.Location = new System.Drawing.Point(10, 370);
            this.lblMetaInfo.Text = "Meta info:";

            this.cmbMetaInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbMetaInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbMetaInfo.ForeColor = System.Drawing.Color.White;
            this.cmbMetaInfo.Location = new System.Drawing.Point(110, 365);
            this.cmbMetaInfo.Size = new System.Drawing.Size(420, 26);
            this.cmbMetaInfo.Items.Add("Every row");
            this.cmbMetaInfo.SelectedIndex = 0;

            this.btnBrowseMeta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBrowseMeta.BorderThickness = 1;
            this.btnBrowseMeta.BorderColor = System.Drawing.Color.Gray;
            this.btnBrowseMeta.ForeColor = System.Drawing.Color.White;
            this.btnBrowseMeta.Location = new System.Drawing.Point(535, 365);
            this.btnBrowseMeta.Size = new System.Drawing.Size(30, 26);
            this.btnBrowseMeta.Text = "...";

            // lblAlias
            this.lblAlias.AutoSize = true;
            this.lblAlias.ForeColor = System.Drawing.Color.LightGray;
            this.lblAlias.Location = new System.Drawing.Point(10, 400);
            this.lblAlias.Text = "Alias:";

            this.txtAlias.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtAlias.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtAlias.ForeColor = System.Drawing.Color.White;
            this.txtAlias.Location = new System.Drawing.Point(110, 395);
            this.txtAlias.Size = new System.Drawing.Size(455, 26);
            this.txtAlias.Text = "my";

            // ctrTableInfo
          //  this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.components.Add(this.txtTitle);
            this.components.Add(this.lblIconInfo);
            this.components.Add(this.lblFile);
            this.components.Add(this.txtFileBox);
            this.components.Add(this.btnBrowseFile);
            this.components.Add(this.lblType);
            this.components.Add(this.cmbType);
            this.components.Add(this.lblIgnore);
            this.components.Add(this.cmbIgnore);
            this.components.Add(this.chkHasHeader);
            this.components.Add(this.lblUseSchema);
            this.components.Add(this.cmbSchema);
            this.components.Add(this.lblWhitespace);
            this.components.Add(this.chkTrim);
            this.components.Add(this.chkSimplify);
            this.components.Add(this.lblIgnoreEmpty);
            this.components.Add(this.chkEmptyRows);
            this.components.Add(this.chkEmptyCols);
            this.components.Add(this.lblIgnoreHidden);
            this.components.Add(this.chkHiddenRows);
            this.components.Add(this.chkHiddenCols);
            this.components.Add(this.chkWatchFile);
            this.components.Add(this.lblMetaInfo);
            this.components.Add(this.cmbMetaInfo);
            this.components.Add(this.btnBrowseMeta);
            this.components.Add(this.lblAlias);
            this.components.Add(this.txtAlias);
            this.components.Add(this.txtTitle);
            //this.Name = "ctrTableInfo";
            //this.Size = new System.Drawing.Size(600, 450);
            //this.Font = new System.Drawing.Font("Segoe UI", 9F);
            //this.ResumeLayout(false);
            //this.PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private System.Windows.Forms.Label lblIconInfo;

        private System.Windows.Forms.Label lblFile;
        private Guna.UI2.WinForms.Guna2TextBox txtFileBox;
        private Guna.UI2.WinForms.Guna2Button btnBrowseFile;

        private System.Windows.Forms.Label lblType;
        private Guna.UI2.WinForms.Guna2ComboBox cmbType;

        private System.Windows.Forms.Label lblIgnore;
        private Guna.UI2.WinForms.Guna2ComboBox cmbIgnore;
        private Guna.UI2.WinForms.Guna2CheckBox chkHasHeader;

        private System.Windows.Forms.Label lblUseSchema;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSchema;

        private System.Windows.Forms.Label lblWhitespace;
        private Guna.UI2.WinForms.Guna2CheckBox chkTrim;
        private Guna.UI2.WinForms.Guna2CheckBox chkSimplify;

        private System.Windows.Forms.Label lblIgnoreEmpty;
        private Guna.UI2.WinForms.Guna2CheckBox chkEmptyRows;
        private Guna.UI2.WinForms.Guna2CheckBox chkEmptyCols;

        private System.Windows.Forms.Label lblIgnoreHidden;
        private Guna.UI2.WinForms.Guna2CheckBox chkHiddenRows;
        private Guna.UI2.WinForms.Guna2CheckBox chkHiddenCols;

        private Guna.UI2.WinForms.Guna2CheckBox chkWatchFile;

        private System.Windows.Forms.Label lblMetaInfo;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMetaInfo;
        private Guna.UI2.WinForms.Guna2Button btnBrowseMeta;

        private System.Windows.Forms.Label lblAlias;
        private Guna.UI2.WinForms.Guna2TextBox txtAlias;
    }
}