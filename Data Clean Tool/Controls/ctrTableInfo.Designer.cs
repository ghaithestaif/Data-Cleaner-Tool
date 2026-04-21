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
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIconInfo = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtFileBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBrowseFile = new Guna.UI2.WinForms.Guna2Button();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblIgnore = new System.Windows.Forms.Label();
            this.cmbIgnore = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chkHasHeader = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblUseSchema = new System.Windows.Forms.Label();
            this.cmbSchema = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblWhitespace = new System.Windows.Forms.Label();
            this.chkTrim = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkSimplify = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblIgnoreEmpty = new System.Windows.Forms.Label();
            this.chkEmptyRows = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkEmptyCols = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblIgnoreHidden = new System.Windows.Forms.Label();
            this.chkHiddenRows = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkHiddenCols = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkWatchFile = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblMetaInfo = new System.Windows.Forms.Label();
            this.cmbMetaInfo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnBrowseMeta = new Guna.UI2.WinForms.Guna2Button();
            this.lblAlias = new System.Windows.Forms.Label();
            this.txtAlias = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.BorderColor = System.Drawing.Color.Fuchsia;
            this.txtTitle.BorderThickness = 2;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "my.xlsx[Sheet1]";
            this.txtTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(10, 10);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(460, 30);
            this.txtTitle.TabIndex = 0;
            // 
            // lblIconInfo
            // 
            this.lblIconInfo.AutoSize = true;
            this.lblIconInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblIconInfo.Location = new System.Drawing.Point(10, 55);
            this.lblIconInfo.Name = "lblIconInfo";
            this.lblIconInfo.Size = new System.Drawing.Size(102, 15);
            this.lblIconInfo.TabIndex = 1;
            this.lblIconInfo.Text = "(?) Input from file.";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.ForeColor = System.Drawing.Color.LightGray;
            this.lblFile.Location = new System.Drawing.Point(10, 95);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(28, 15);
            this.lblFile.TabIndex = 2;
            this.lblFile.Text = "File:";
            // 
            // txtFileBox
            // 
            this.txtFileBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtFileBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFileBox.DefaultText = "D:\\Users\\Desktop\\my.xlsx[Sheet1]";
            this.txtFileBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtFileBox.ForeColor = System.Drawing.Color.White;
            this.txtFileBox.Location = new System.Drawing.Point(110, 90);
            this.txtFileBox.Name = "txtFileBox";
            this.txtFileBox.PasswordChar = '\0';
            this.txtFileBox.SelectedText = "";
            this.txtFileBox.Size = new System.Drawing.Size(420, 26);
            this.txtFileBox.TabIndex = 3;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.BorderColor = System.Drawing.Color.Gray;
            this.btnBrowseFile.BorderThickness = 1;
            this.btnBrowseFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBrowseFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseFile.ForeColor = System.Drawing.Color.White;
            this.btnBrowseFile.Location = new System.Drawing.Point(535, 90);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(30, 26);
            this.btnBrowseFile.TabIndex = 4;
            this.btnBrowseFile.Text = "...";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.Color.LightGray;
            this.lblType.Location = new System.Drawing.Point(10, 125);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 15);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type:";
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.Transparent;
            this.cmbType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbType.ForeColor = System.Drawing.Color.White;
            this.cmbType.ItemHeight = 20;
            this.cmbType.Items.AddRange(new object[] {
            "Excel XLSX"});
            this.cmbType.Location = new System.Drawing.Point(110, 120);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(455, 26);
            this.cmbType.StartIndex = 0;
            this.cmbType.TabIndex = 6;
            // 
            // lblIgnore
            // 
            this.lblIgnore.AutoSize = true;
            this.lblIgnore.ForeColor = System.Drawing.Color.LightGray;
            this.lblIgnore.Location = new System.Drawing.Point(10, 155);
            this.lblIgnore.Name = "lblIgnore";
            this.lblIgnore.Size = new System.Drawing.Size(44, 15);
            this.lblIgnore.TabIndex = 7;
            this.lblIgnore.Text = "Ignore:";
            // 
            // cmbIgnore
            // 
            this.cmbIgnore.BackColor = System.Drawing.Color.Transparent;
            this.cmbIgnore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbIgnore.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIgnore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIgnore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbIgnore.FocusedColor = System.Drawing.Color.Empty;
            this.cmbIgnore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIgnore.ForeColor = System.Drawing.Color.White;
            this.cmbIgnore.ItemHeight = 20;
            this.cmbIgnore.Items.AddRange(new object[] {
            "First 0 row(s)"});
            this.cmbIgnore.Location = new System.Drawing.Point(110, 150);
            this.cmbIgnore.Name = "cmbIgnore";
            this.cmbIgnore.Size = new System.Drawing.Size(455, 26);
            this.cmbIgnore.StartIndex = 0;
            this.cmbIgnore.TabIndex = 8;
            // 
            // chkHasHeader
            // 
            this.chkHasHeader.AutoSize = true;
            this.chkHasHeader.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkHasHeader.CheckedState.BorderRadius = 0;
            this.chkHasHeader.CheckedState.BorderThickness = 0;
            this.chkHasHeader.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkHasHeader.ForeColor = System.Drawing.Color.LightGray;
            this.chkHasHeader.Location = new System.Drawing.Point(110, 180);
            this.chkHasHeader.Name = "chkHasHeader";
            this.chkHasHeader.Size = new System.Drawing.Size(83, 19);
            this.chkHasHeader.TabIndex = 9;
            this.chkHasHeader.Text = "has header";
            this.chkHasHeader.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkHasHeader.UncheckedState.BorderRadius = 0;
            this.chkHasHeader.UncheckedState.BorderThickness = 0;
            this.chkHasHeader.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // lblUseSchema
            // 
            this.lblUseSchema.AutoSize = true;
            this.lblUseSchema.ForeColor = System.Drawing.Color.LightGray;
            this.lblUseSchema.Location = new System.Drawing.Point(10, 215);
            this.lblUseSchema.Name = "lblUseSchema";
            this.lblUseSchema.Size = new System.Drawing.Size(73, 15);
            this.lblUseSchema.TabIndex = 10;
            this.lblUseSchema.Text = "Use schema:";
            // 
            // cmbSchema
            // 
            this.cmbSchema.BackColor = System.Drawing.Color.Transparent;
            this.cmbSchema.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbSchema.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSchema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchema.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbSchema.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSchema.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSchema.ForeColor = System.Drawing.Color.White;
            this.cmbSchema.ItemHeight = 20;
            this.cmbSchema.Items.AddRange(new object[] {
            "No"});
            this.cmbSchema.Location = new System.Drawing.Point(110, 210);
            this.cmbSchema.Name = "cmbSchema";
            this.cmbSchema.Size = new System.Drawing.Size(455, 26);
            this.cmbSchema.StartIndex = 0;
            this.cmbSchema.TabIndex = 11;
            // 
            // lblWhitespace
            // 
            this.lblWhitespace.AutoSize = true;
            this.lblWhitespace.ForeColor = System.Drawing.Color.LightGray;
            this.lblWhitespace.Location = new System.Drawing.Point(10, 245);
            this.lblWhitespace.Name = "lblWhitespace";
            this.lblWhitespace.Size = new System.Drawing.Size(71, 15);
            this.lblWhitespace.TabIndex = 12;
            this.lblWhitespace.Text = "Whitespace:";
            // 
            // chkTrim
            // 
            this.chkTrim.AutoSize = true;
            this.chkTrim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkTrim.CheckedState.BorderRadius = 0;
            this.chkTrim.CheckedState.BorderThickness = 0;
            this.chkTrim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkTrim.ForeColor = System.Drawing.Color.LightGray;
            this.chkTrim.Location = new System.Drawing.Point(110, 245);
            this.chkTrim.Name = "chkTrim";
            this.chkTrim.Size = new System.Drawing.Size(48, 19);
            this.chkTrim.TabIndex = 13;
            this.chkTrim.Text = "trim";
            this.chkTrim.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkSimplify
            // 
            this.chkSimplify.AutoSize = true;
            this.chkSimplify.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkSimplify.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkSimplify.ForeColor = System.Drawing.Color.LightGray;
            this.chkSimplify.Location = new System.Drawing.Point(320, 245);
            this.chkSimplify.Name = "chkSimplify";
            this.chkSimplify.Size = new System.Drawing.Size(68, 19);
            this.chkSimplify.TabIndex = 14;
            this.chkSimplify.Text = "simplify";
            this.chkSimplify.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // lblIgnoreEmpty
            // 
            this.lblIgnoreEmpty.AutoSize = true;
            this.lblIgnoreEmpty.ForeColor = System.Drawing.Color.LightGray;
            this.lblIgnoreEmpty.Location = new System.Drawing.Point(10, 275);
            this.lblIgnoreEmpty.Name = "lblIgnoreEmpty";
            this.lblIgnoreEmpty.Size = new System.Drawing.Size(81, 15);
            this.lblIgnoreEmpty.TabIndex = 15;
            this.lblIgnoreEmpty.Text = "Ignore empty:";
            // 
            // chkEmptyRows
            // 
            this.chkEmptyRows.AutoSize = true;
            this.chkEmptyRows.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkEmptyRows.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkEmptyRows.ForeColor = System.Drawing.Color.LightGray;
            this.chkEmptyRows.Location = new System.Drawing.Point(110, 275);
            this.chkEmptyRows.Name = "chkEmptyRows";
            this.chkEmptyRows.Size = new System.Drawing.Size(50, 19);
            this.chkEmptyRows.TabIndex = 16;
            this.chkEmptyRows.Text = "rows";
            this.chkEmptyRows.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkEmptyCols
            // 
            this.chkEmptyCols.AutoSize = true;
            this.chkEmptyCols.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkEmptyCols.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkEmptyCols.ForeColor = System.Drawing.Color.LightGray;
            this.chkEmptyCols.Location = new System.Drawing.Point(320, 275);
            this.chkEmptyCols.Name = "chkEmptyCols";
            this.chkEmptyCols.Size = new System.Drawing.Size(72, 19);
            this.chkEmptyCols.TabIndex = 17;
            this.chkEmptyCols.Text = "columns";
            this.chkEmptyCols.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // lblIgnoreHidden
            // 
            this.lblIgnoreHidden.AutoSize = true;
            this.lblIgnoreHidden.ForeColor = System.Drawing.Color.LightGray;
            this.lblIgnoreHidden.Location = new System.Drawing.Point(10, 305);
            this.lblIgnoreHidden.Name = "lblIgnoreHidden";
            this.lblIgnoreHidden.Size = new System.Drawing.Size(84, 15);
            this.lblIgnoreHidden.TabIndex = 18;
            this.lblIgnoreHidden.Text = "Ignore hidden:";
            // 
            // chkHiddenRows
            // 
            this.chkHiddenRows.AutoSize = true;
            this.chkHiddenRows.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkHiddenRows.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkHiddenRows.ForeColor = System.Drawing.Color.LightGray;
            this.chkHiddenRows.Location = new System.Drawing.Point(110, 305);
            this.chkHiddenRows.Name = "chkHiddenRows";
            this.chkHiddenRows.Size = new System.Drawing.Size(50, 19);
            this.chkHiddenRows.TabIndex = 19;
            this.chkHiddenRows.Text = "rows";
            this.chkHiddenRows.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkHiddenCols
            // 
            this.chkHiddenCols.AutoSize = true;
            this.chkHiddenCols.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkHiddenCols.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkHiddenCols.ForeColor = System.Drawing.Color.LightGray;
            this.chkHiddenCols.Location = new System.Drawing.Point(320, 305);
            this.chkHiddenCols.Name = "chkHiddenCols";
            this.chkHiddenCols.Size = new System.Drawing.Size(72, 19);
            this.chkHiddenCols.TabIndex = 20;
            this.chkHiddenCols.Text = "columns";
            this.chkHiddenCols.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkWatchFile
            // 
            this.chkWatchFile.AutoSize = true;
            this.chkWatchFile.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkWatchFile.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkWatchFile.ForeColor = System.Drawing.Color.LightGray;
            this.chkWatchFile.Location = new System.Drawing.Point(110, 335);
            this.chkWatchFile.Name = "chkWatchFile";
            this.chkWatchFile.Size = new System.Drawing.Size(76, 19);
            this.chkWatchFile.TabIndex = 21;
            this.chkWatchFile.Text = "watch file";
            this.chkWatchFile.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // lblMetaInfo
            // 
            this.lblMetaInfo.AutoSize = true;
            this.lblMetaInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblMetaInfo.Location = new System.Drawing.Point(10, 370);
            this.lblMetaInfo.Name = "lblMetaInfo";
            this.lblMetaInfo.Size = new System.Drawing.Size(60, 15);
            this.lblMetaInfo.TabIndex = 22;
            this.lblMetaInfo.Text = "Meta info:";
            // 
            // cmbMetaInfo
            // 
            this.cmbMetaInfo.BackColor = System.Drawing.Color.Transparent;
            this.cmbMetaInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbMetaInfo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMetaInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetaInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbMetaInfo.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMetaInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMetaInfo.ForeColor = System.Drawing.Color.White;
            this.cmbMetaInfo.ItemHeight = 20;
            this.cmbMetaInfo.Items.AddRange(new object[] {
            "Every row"});
            this.cmbMetaInfo.Location = new System.Drawing.Point(110, 365);
            this.cmbMetaInfo.Name = "cmbMetaInfo";
            this.cmbMetaInfo.Size = new System.Drawing.Size(420, 26);
            this.cmbMetaInfo.StartIndex = 0;
            this.cmbMetaInfo.TabIndex = 23;
            // 
            // btnBrowseMeta
            // 
            this.btnBrowseMeta.BorderColor = System.Drawing.Color.Gray;
            this.btnBrowseMeta.BorderThickness = 1;
            this.btnBrowseMeta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBrowseMeta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseMeta.ForeColor = System.Drawing.Color.White;
            this.btnBrowseMeta.Location = new System.Drawing.Point(535, 365);
            this.btnBrowseMeta.Name = "btnBrowseMeta";
            this.btnBrowseMeta.Size = new System.Drawing.Size(30, 26);
            this.btnBrowseMeta.TabIndex = 24;
            this.btnBrowseMeta.Text = "...";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.ForeColor = System.Drawing.Color.LightGray;
            this.lblAlias.Location = new System.Drawing.Point(10, 400);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(35, 15);
            this.lblAlias.TabIndex = 25;
            this.lblAlias.Text = "Alias:";
            // 
            // txtAlias
            // 
            this.txtAlias.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtAlias.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlias.DefaultText = "my";
            this.txtAlias.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtAlias.ForeColor = System.Drawing.Color.White;
            this.txtAlias.Location = new System.Drawing.Point(110, 395);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.PasswordChar = '\0';
            this.txtAlias.SelectedText = "";
            this.txtAlias.Size = new System.Drawing.Size(455, 26);
            this.txtAlias.TabIndex = 26;
            // 
            // ctrTableInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.btnBrowseMeta);
            this.Controls.Add(this.cmbMetaInfo);
            this.Controls.Add(this.lblMetaInfo);
            this.Controls.Add(this.chkWatchFile);
            this.Controls.Add(this.chkHiddenCols);
            this.Controls.Add(this.chkHiddenRows);
            this.Controls.Add(this.lblIgnoreHidden);
            this.Controls.Add(this.chkEmptyCols);
            this.Controls.Add(this.chkEmptyRows);
            this.Controls.Add(this.lblIgnoreEmpty);
            this.Controls.Add(this.chkSimplify);
            this.Controls.Add(this.chkTrim);
            this.Controls.Add(this.lblWhitespace);
            this.Controls.Add(this.cmbSchema);
            this.Controls.Add(this.lblUseSchema);
            this.Controls.Add(this.chkHasHeader);
            this.Controls.Add(this.cmbIgnore);
            this.Controls.Add(this.lblIgnore);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.txtFileBox);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblIconInfo);
            this.Controls.Add(this.txtTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ctrTableInfo";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

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
