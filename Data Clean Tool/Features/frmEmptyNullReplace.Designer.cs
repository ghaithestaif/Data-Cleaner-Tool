namespace Data_Clean_Tool.Features
{
    partial class frmEmptyNullReplace
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

        #region Windows Form Designer generated code

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
            rbReplaceWithDefualtValue = new Guna.UI2.WinForms.Guna2RadioButton();
            rbRemoveRow = new Guna.UI2.WinForms.Guna2RadioButton();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // rbReplaceWithDefualtValue
            // 
            rbReplaceWithDefualtValue.AutoSize = true;
            rbReplaceWithDefualtValue.BackColor = Color.FromArgb(35, 35, 35);
            rbReplaceWithDefualtValue.Checked = true;
            rbReplaceWithDefualtValue.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            rbReplaceWithDefualtValue.CheckedState.BorderThickness = 0;
            rbReplaceWithDefualtValue.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            rbReplaceWithDefualtValue.CheckedState.InnerColor = Color.White;
            rbReplaceWithDefualtValue.CheckedState.InnerOffset = -4;
            rbReplaceWithDefualtValue.ForeColor = SystemColors.Control;
            rbReplaceWithDefualtValue.Location = new Point(28, 53);
            rbReplaceWithDefualtValue.Name = "rbReplaceWithDefualtValue";
            rbReplaceWithDefualtValue.Size = new Size(205, 24);
            rbReplaceWithDefualtValue.TabIndex = 0;
            rbReplaceWithDefualtValue.TabStop = true;
            rbReplaceWithDefualtValue.Text = "Replace with defualt value";
            rbReplaceWithDefualtValue.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rbReplaceWithDefualtValue.UncheckedState.BorderThickness = 2;
            rbReplaceWithDefualtValue.UncheckedState.FillColor = Color.Transparent;
            rbReplaceWithDefualtValue.UncheckedState.InnerColor = Color.Transparent;
            rbReplaceWithDefualtValue.UseVisualStyleBackColor = false;
            rbReplaceWithDefualtValue.CheckedChanged += rbReplaceWithDefualtValue_CheckedChanged;
            // 
            // rbRemoveRow
            // 
            rbRemoveRow.AutoSize = true;
            rbRemoveRow.BackColor = Color.FromArgb(35, 35, 35);
            rbRemoveRow.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            rbRemoveRow.CheckedState.BorderThickness = 0;
            rbRemoveRow.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            rbRemoveRow.CheckedState.InnerColor = Color.White;
            rbRemoveRow.CheckedState.InnerOffset = -4;
            rbRemoveRow.ForeColor = SystemColors.Control;
            rbRemoveRow.Location = new Point(28, 83);
            rbRemoveRow.Name = "rbRemoveRow";
            rbRemoveRow.Size = new Size(109, 24);
            rbRemoveRow.TabIndex = 1;
            rbRemoveRow.Text = "remove row";
            rbRemoveRow.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rbRemoveRow.UncheckedState.BorderThickness = 2;
            rbRemoveRow.UncheckedState.FillColor = Color.Transparent;
            rbRemoveRow.UncheckedState.InnerColor = Color.Transparent;
            rbRemoveRow.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BorderColor = Color.Gray;
            btnCancel.BorderRadius = 17;
            btnCancel.BorderThickness = 1;
            btnCancel.CustomizableEdges = customizableEdges1;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(40, 40, 40);
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.LightGray;
            btnCancel.Location = new Point(42, 149);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCancel.Size = new Size(83, 36);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = HorizontalAlignment.Left;
            btnCancel.TextOffset = new Point(10, 0);
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BorderColor = Color.Gray;
            btnSave.BorderRadius = 17;
            btnSave.BorderThickness = 1;
            btnSave.CustomizableEdges = customizableEdges3;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(40, 40, 40);
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = Color.LightGray;
            btnSave.Location = new Point(148, 149);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSave.Size = new Size(83, 36);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.TextAlign = HorizontalAlignment.Left;
            btnSave.TextOffset = new Point(10, 0);
            btnSave.Click += btnSave_Click;
            // 
            // frmEmptyNullReplace
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(276, 208);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(rbRemoveRow);
            Controls.Add(rbReplaceWithDefualtValue);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmEmptyNullReplace";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Empty Null Replace";
            Load += frmEmptyNullReplace_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2RadioButton rbReplaceWithDefualtValue;
        private Guna.UI2.WinForms.Guna2RadioButton rbRemoveRow;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}