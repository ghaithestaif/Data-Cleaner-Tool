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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            lblIconInfo = new Label();
            lblFile = new Label();
            txtFileBox = new Guna.UI2.WinForms.Guna2TextBox();
            btnBrowseFile = new Guna.UI2.WinForms.Guna2Button();
            lblType = new Label();
            cmbType = new Guna.UI2.WinForms.Guna2ComboBox();
            lblIgnore = new Label();
            cmbIgnore = new Guna.UI2.WinForms.Guna2ComboBox();
            chkHasHeader = new Guna.UI2.WinForms.Guna2CheckBox();
            lblUseSchema = new Label();
            cmbSchema = new Guna.UI2.WinForms.Guna2ComboBox();
            lblWhitespace = new Label();
            chkTrim = new Guna.UI2.WinForms.Guna2CheckBox();
            chkSimplify = new Guna.UI2.WinForms.Guna2CheckBox();
            lblIgnoreEmpty = new Label();
            chkEmptyRows = new Guna.UI2.WinForms.Guna2CheckBox();
            chkEmptyCols = new Guna.UI2.WinForms.Guna2CheckBox();
            lblIgnoreHidden = new Label();
            chkHiddenRows = new Guna.UI2.WinForms.Guna2CheckBox();
            chkHiddenCols = new Guna.UI2.WinForms.Guna2CheckBox();
            chkWatchFile = new Guna.UI2.WinForms.Guna2CheckBox();
            lblMetaInfo = new Label();
            cmbMetaInfo = new Guna.UI2.WinForms.Guna2ComboBox();
            btnBrowseMeta = new Guna.UI2.WinForms.Guna2Button();
            lblAlias = new Label();
            txtAlias = new Guna.UI2.WinForms.Guna2TextBox();
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
            txtTitle.Location = new Point(10, 10);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "";
            txtTitle.SelectedText = "";
            txtTitle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTitle.Size = new Size(460, 30);
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
            lblFile.Location = new Point(10, 95);
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
            txtFileBox.CustomizableEdges = customizableEdges3;
            txtFileBox.DefaultText = "D:\\Users\\Desktop\\my.xlsx[Sheet1]";
            txtFileBox.FillColor = Color.FromArgb(40, 40, 40);
            txtFileBox.Font = new Font("Segoe UI", 9F);
            txtFileBox.ForeColor = Color.White;
            txtFileBox.Location = new Point(110, 90);
            txtFileBox.Name = "txtFileBox";
            txtFileBox.PlaceholderText = "";
            txtFileBox.SelectedText = "";
            txtFileBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtFileBox.Size = new Size(411, 26);
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
            btnBrowseFile.Location = new Point(527, 88);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnBrowseFile.Size = new Size(35, 26);
            btnBrowseFile.TabIndex = 4;
            btnBrowseFile.Text = "...";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.ForeColor = Color.LightGray;
            lblType.Location = new Point(10, 125);
            lblType.Name = "lblType";
            lblType.Size = new Size(35, 15);
            lblType.TabIndex = 5;
            lblType.Text = "Type:";
            // 
            // cmbType
            // 
            cmbType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbType.BackColor = Color.Transparent;
            cmbType.BorderColor = Color.FromArgb(60, 60, 60);
            cmbType.CustomizableEdges = customizableEdges7;
            cmbType.DrawMode = DrawMode.OwnerDrawFixed;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FillColor = Color.FromArgb(40, 40, 40);
            cmbType.FocusedColor = Color.Empty;
            cmbType.Font = new Font("Segoe UI", 10F);
            cmbType.ForeColor = Color.White;
            cmbType.ItemHeight = 20;
            cmbType.Items.AddRange(new object[] { "Excel XLSX" });
            cmbType.Location = new Point(110, 120);
            cmbType.Name = "cmbType";
            cmbType.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cmbType.Size = new Size(441, 26);
            cmbType.StartIndex = 0;
            cmbType.TabIndex = 6;
            // 
            // lblIgnore
            // 
            lblIgnore.AutoSize = true;
            lblIgnore.ForeColor = Color.LightGray;
            lblIgnore.Location = new Point(10, 155);
            lblIgnore.Name = "lblIgnore";
            lblIgnore.Size = new Size(44, 15);
            lblIgnore.TabIndex = 7;
            lblIgnore.Text = "Ignore:";
            // 
            // cmbIgnore
            // 
            cmbIgnore.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbIgnore.BackColor = Color.Transparent;
            cmbIgnore.BorderColor = Color.FromArgb(60, 60, 60);
            cmbIgnore.CustomizableEdges = customizableEdges9;
            cmbIgnore.DrawMode = DrawMode.OwnerDrawFixed;
            cmbIgnore.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIgnore.FillColor = Color.FromArgb(40, 40, 40);
            cmbIgnore.FocusedColor = Color.Empty;
            cmbIgnore.Font = new Font("Segoe UI", 10F);
            cmbIgnore.ForeColor = Color.White;
            cmbIgnore.ItemHeight = 20;
            cmbIgnore.Items.AddRange(new object[] { "First 0 row(s)" });
            cmbIgnore.Location = new Point(110, 150);
            cmbIgnore.Name = "cmbIgnore";
            cmbIgnore.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cmbIgnore.Size = new Size(441, 26);
            cmbIgnore.StartIndex = 0;
            cmbIgnore.TabIndex = 8;
            // 
            // chkHasHeader
            // 
            chkHasHeader.AutoSize = true;
            chkHasHeader.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkHasHeader.CheckedState.BorderRadius = 0;
            chkHasHeader.CheckedState.BorderThickness = 0;
            chkHasHeader.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkHasHeader.ForeColor = Color.LightGray;
            chkHasHeader.Location = new Point(110, 180);
            chkHasHeader.Name = "chkHasHeader";
            chkHasHeader.Size = new Size(83, 19);
            chkHasHeader.TabIndex = 9;
            chkHasHeader.Text = "has header";
            chkHasHeader.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkHasHeader.UncheckedState.BorderRadius = 0;
            chkHasHeader.UncheckedState.BorderThickness = 0;
            chkHasHeader.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // lblUseSchema
            // 
            lblUseSchema.AutoSize = true;
            lblUseSchema.ForeColor = Color.LightGray;
            lblUseSchema.Location = new Point(10, 215);
            lblUseSchema.Name = "lblUseSchema";
            lblUseSchema.Size = new Size(73, 15);
            lblUseSchema.TabIndex = 10;
            lblUseSchema.Text = "Use schema:";
            // 
            // cmbSchema
            // 
            cmbSchema.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbSchema.BackColor = Color.Transparent;
            cmbSchema.BorderColor = Color.FromArgb(60, 60, 60);
            cmbSchema.CustomizableEdges = customizableEdges11;
            cmbSchema.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSchema.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSchema.FillColor = Color.FromArgb(40, 40, 40);
            cmbSchema.FocusedColor = Color.Empty;
            cmbSchema.Font = new Font("Segoe UI", 10F);
            cmbSchema.ForeColor = Color.White;
            cmbSchema.ItemHeight = 20;
            cmbSchema.Items.AddRange(new object[] { "No" });
            cmbSchema.Location = new Point(110, 210);
            cmbSchema.Name = "cmbSchema";
            cmbSchema.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cmbSchema.Size = new Size(441, 26);
            cmbSchema.StartIndex = 0;
            cmbSchema.TabIndex = 11;
            // 
            // lblWhitespace
            // 
            lblWhitespace.AutoSize = true;
            lblWhitespace.ForeColor = Color.LightGray;
            lblWhitespace.Location = new Point(10, 245);
            lblWhitespace.Name = "lblWhitespace";
            lblWhitespace.Size = new Size(71, 15);
            lblWhitespace.TabIndex = 12;
            lblWhitespace.Text = "Whitespace:";
            // 
            // chkTrim
            // 
            chkTrim.AutoSize = true;
            chkTrim.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkTrim.CheckedState.BorderRadius = 0;
            chkTrim.CheckedState.BorderThickness = 0;
            chkTrim.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkTrim.ForeColor = Color.LightGray;
            chkTrim.Location = new Point(110, 245);
            chkTrim.Name = "chkTrim";
            chkTrim.Size = new Size(48, 19);
            chkTrim.TabIndex = 13;
            chkTrim.Text = "trim";
            chkTrim.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkTrim.UncheckedState.BorderRadius = 0;
            chkTrim.UncheckedState.BorderThickness = 0;
            // 
            // chkSimplify
            // 
            chkSimplify.AutoSize = true;
            chkSimplify.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkSimplify.CheckedState.BorderRadius = 0;
            chkSimplify.CheckedState.BorderThickness = 0;
            chkSimplify.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkSimplify.ForeColor = Color.LightGray;
            chkSimplify.Location = new Point(320, 245);
            chkSimplify.Name = "chkSimplify";
            chkSimplify.Size = new Size(68, 19);
            chkSimplify.TabIndex = 14;
            chkSimplify.Text = "simplify";
            chkSimplify.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkSimplify.UncheckedState.BorderRadius = 0;
            chkSimplify.UncheckedState.BorderThickness = 0;
            // 
            // lblIgnoreEmpty
            // 
            lblIgnoreEmpty.AutoSize = true;
            lblIgnoreEmpty.ForeColor = Color.LightGray;
            lblIgnoreEmpty.Location = new Point(10, 275);
            lblIgnoreEmpty.Name = "lblIgnoreEmpty";
            lblIgnoreEmpty.Size = new Size(81, 15);
            lblIgnoreEmpty.TabIndex = 15;
            lblIgnoreEmpty.Text = "Ignore empty:";
            // 
            // chkEmptyRows
            // 
            chkEmptyRows.AutoSize = true;
            chkEmptyRows.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkEmptyRows.CheckedState.BorderRadius = 0;
            chkEmptyRows.CheckedState.BorderThickness = 0;
            chkEmptyRows.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkEmptyRows.ForeColor = Color.LightGray;
            chkEmptyRows.Location = new Point(110, 275);
            chkEmptyRows.Name = "chkEmptyRows";
            chkEmptyRows.Size = new Size(51, 19);
            chkEmptyRows.TabIndex = 16;
            chkEmptyRows.Text = "rows";
            chkEmptyRows.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkEmptyRows.UncheckedState.BorderRadius = 0;
            chkEmptyRows.UncheckedState.BorderThickness = 0;
            // 
            // chkEmptyCols
            // 
            chkEmptyCols.AutoSize = true;
            chkEmptyCols.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkEmptyCols.CheckedState.BorderRadius = 0;
            chkEmptyCols.CheckedState.BorderThickness = 0;
            chkEmptyCols.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkEmptyCols.ForeColor = Color.LightGray;
            chkEmptyCols.Location = new Point(320, 275);
            chkEmptyCols.Name = "chkEmptyCols";
            chkEmptyCols.Size = new Size(72, 19);
            chkEmptyCols.TabIndex = 17;
            chkEmptyCols.Text = "columns";
            chkEmptyCols.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkEmptyCols.UncheckedState.BorderRadius = 0;
            chkEmptyCols.UncheckedState.BorderThickness = 0;
            // 
            // lblIgnoreHidden
            // 
            lblIgnoreHidden.AutoSize = true;
            lblIgnoreHidden.ForeColor = Color.LightGray;
            lblIgnoreHidden.Location = new Point(10, 305);
            lblIgnoreHidden.Name = "lblIgnoreHidden";
            lblIgnoreHidden.Size = new Size(84, 15);
            lblIgnoreHidden.TabIndex = 18;
            lblIgnoreHidden.Text = "Ignore hidden:";
            // 
            // chkHiddenRows
            // 
            chkHiddenRows.AutoSize = true;
            chkHiddenRows.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkHiddenRows.CheckedState.BorderRadius = 0;
            chkHiddenRows.CheckedState.BorderThickness = 0;
            chkHiddenRows.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkHiddenRows.ForeColor = Color.LightGray;
            chkHiddenRows.Location = new Point(110, 305);
            chkHiddenRows.Name = "chkHiddenRows";
            chkHiddenRows.Size = new Size(51, 19);
            chkHiddenRows.TabIndex = 19;
            chkHiddenRows.Text = "rows";
            chkHiddenRows.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkHiddenRows.UncheckedState.BorderRadius = 0;
            chkHiddenRows.UncheckedState.BorderThickness = 0;
            // 
            // chkHiddenCols
            // 
            chkHiddenCols.AutoSize = true;
            chkHiddenCols.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkHiddenCols.CheckedState.BorderRadius = 0;
            chkHiddenCols.CheckedState.BorderThickness = 0;
            chkHiddenCols.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkHiddenCols.ForeColor = Color.LightGray;
            chkHiddenCols.Location = new Point(320, 305);
            chkHiddenCols.Name = "chkHiddenCols";
            chkHiddenCols.Size = new Size(72, 19);
            chkHiddenCols.TabIndex = 20;
            chkHiddenCols.Text = "columns";
            chkHiddenCols.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkHiddenCols.UncheckedState.BorderRadius = 0;
            chkHiddenCols.UncheckedState.BorderThickness = 0;
            // 
            // chkWatchFile
            // 
            chkWatchFile.AutoSize = true;
            chkWatchFile.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkWatchFile.CheckedState.BorderRadius = 0;
            chkWatchFile.CheckedState.BorderThickness = 0;
            chkWatchFile.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkWatchFile.ForeColor = Color.LightGray;
            chkWatchFile.Location = new Point(110, 335);
            chkWatchFile.Name = "chkWatchFile";
            chkWatchFile.Size = new Size(77, 19);
            chkWatchFile.TabIndex = 21;
            chkWatchFile.Text = "watch file";
            chkWatchFile.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkWatchFile.UncheckedState.BorderRadius = 0;
            chkWatchFile.UncheckedState.BorderThickness = 0;
            // 
            // lblMetaInfo
            // 
            lblMetaInfo.AutoSize = true;
            lblMetaInfo.ForeColor = Color.LightGray;
            lblMetaInfo.Location = new Point(10, 370);
            lblMetaInfo.Name = "lblMetaInfo";
            lblMetaInfo.Size = new Size(61, 15);
            lblMetaInfo.TabIndex = 22;
            lblMetaInfo.Text = "Meta info:";
            // 
            // cmbMetaInfo
            // 
            cmbMetaInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbMetaInfo.BackColor = Color.Transparent;
            cmbMetaInfo.BorderColor = Color.FromArgb(60, 60, 60);
            cmbMetaInfo.CustomizableEdges = customizableEdges13;
            cmbMetaInfo.DrawMode = DrawMode.OwnerDrawFixed;
            cmbMetaInfo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetaInfo.FillColor = Color.FromArgb(40, 40, 40);
            cmbMetaInfo.FocusedColor = Color.Empty;
            cmbMetaInfo.Font = new Font("Segoe UI", 10F);
            cmbMetaInfo.ForeColor = Color.White;
            cmbMetaInfo.ItemHeight = 20;
            cmbMetaInfo.Items.AddRange(new object[] { "Every row" });
            cmbMetaInfo.Location = new Point(110, 365);
            cmbMetaInfo.Name = "cmbMetaInfo";
            cmbMetaInfo.ShadowDecoration.CustomizableEdges = customizableEdges14;
            cmbMetaInfo.Size = new Size(406, 26);
            cmbMetaInfo.StartIndex = 0;
            cmbMetaInfo.TabIndex = 23;
            // 
            // btnBrowseMeta
            // 
            btnBrowseMeta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseMeta.BorderColor = Color.Gray;
            btnBrowseMeta.BorderThickness = 1;
            btnBrowseMeta.CustomizableEdges = customizableEdges15;
            btnBrowseMeta.FillColor = Color.FromArgb(45, 45, 45);
            btnBrowseMeta.Font = new Font("Segoe UI", 9F);
            btnBrowseMeta.ForeColor = Color.White;
            btnBrowseMeta.Location = new Point(527, 365);
            btnBrowseMeta.Name = "btnBrowseMeta";
            btnBrowseMeta.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnBrowseMeta.Size = new Size(35, 26);
            btnBrowseMeta.TabIndex = 24;
            btnBrowseMeta.Text = "...";
            // 
            // lblAlias
            // 
            lblAlias.AutoSize = true;
            lblAlias.ForeColor = Color.LightGray;
            lblAlias.Location = new Point(10, 400);
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
            txtAlias.CustomizableEdges = customizableEdges17;
            txtAlias.DefaultText = "my";
            txtAlias.FillColor = Color.FromArgb(40, 40, 40);
            txtAlias.Font = new Font("Segoe UI", 9F);
            txtAlias.ForeColor = Color.White;
            txtAlias.Location = new Point(110, 395);
            txtAlias.Name = "txtAlias";
            txtAlias.PlaceholderText = "";
            txtAlias.SelectedText = "";
            txtAlias.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtAlias.Size = new Size(441, 26);
            txtAlias.TabIndex = 26;
            // 
            // ctrTableInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            Controls.Add(txtAlias);
            Controls.Add(lblAlias);
            Controls.Add(btnBrowseMeta);
            Controls.Add(cmbMetaInfo);
            Controls.Add(lblMetaInfo);
            Controls.Add(chkWatchFile);
            Controls.Add(chkHiddenCols);
            Controls.Add(chkHiddenRows);
            Controls.Add(lblIgnoreHidden);
            Controls.Add(chkEmptyCols);
            Controls.Add(chkEmptyRows);
            Controls.Add(lblIgnoreEmpty);
            Controls.Add(chkSimplify);
            Controls.Add(chkTrim);
            Controls.Add(lblWhitespace);
            Controls.Add(cmbSchema);
            Controls.Add(lblUseSchema);
            Controls.Add(chkHasHeader);
            Controls.Add(cmbIgnore);
            Controls.Add(lblIgnore);
            Controls.Add(cmbType);
            Controls.Add(lblType);
            Controls.Add(btnBrowseFile);
            Controls.Add(txtFileBox);
            Controls.Add(lblFile);
            Controls.Add(lblIconInfo);
            Controls.Add(txtTitle);
            Font = new Font("Segoe UI", 9F);
            Name = "ctrTableInfo";
            Size = new Size(565, 396);
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
