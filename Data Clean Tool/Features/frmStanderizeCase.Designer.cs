namespace Data_Clean_Tool.Features
{
    partial class frmStanderizeCase
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
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            rbLoweCAse = new Guna.UI2.WinForms.Guna2RadioButton();
            rbUpperCase = new Guna.UI2.WinForms.Guna2RadioButton();
            rbTitleCase = new Guna.UI2.WinForms.Guna2RadioButton();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BorderColor = Color.Gray;
            btnSave.BorderRadius = 17;
            btnSave.BorderThickness = 1;
            btnSave.CustomizableEdges = customizableEdges1;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(40, 40, 40);
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = Color.LightGray;
            btnSave.Location = new Point(134, 160);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSave.Size = new Size(83, 36);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.TextAlign = HorizontalAlignment.Left;
            btnSave.TextOffset = new Point(10, 0);
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BorderColor = Color.Gray;
            btnCancel.BorderRadius = 17;
            btnCancel.BorderThickness = 1;
            btnCancel.CustomizableEdges = customizableEdges3;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(40, 40, 40);
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.LightGray;
            btnCancel.Location = new Point(28, 160);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancel.Size = new Size(83, 36);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = HorizontalAlignment.Left;
            btnCancel.TextOffset = new Point(10, 0);
            // 
            // rbLoweCAse
            // 
            rbLoweCAse.AutoSize = true;
            rbLoweCAse.BackColor = Color.FromArgb(35, 35, 35);
            rbLoweCAse.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            rbLoweCAse.CheckedState.BorderThickness = 0;
            rbLoweCAse.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            rbLoweCAse.CheckedState.InnerColor = Color.White;
            rbLoweCAse.CheckedState.InnerOffset = -4;
            rbLoweCAse.ForeColor = SystemColors.Control;
            rbLoweCAse.Location = new Point(28, 74);
            rbLoweCAse.Name = "rbLoweCAse";
            rbLoweCAse.Size = new Size(105, 24);
            rbLoweCAse.TabIndex = 1;
            rbLoweCAse.Text = "Lower Case";
            rbLoweCAse.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rbLoweCAse.UncheckedState.BorderThickness = 2;
            rbLoweCAse.UncheckedState.FillColor = Color.Transparent;
            rbLoweCAse.UncheckedState.InnerColor = Color.Transparent;
            rbLoweCAse.UseVisualStyleBackColor = false;
            // 
            // rbUpperCase
            // 
            rbUpperCase.AutoSize = true;
            rbUpperCase.BackColor = Color.FromArgb(35, 35, 35);
            rbUpperCase.Checked = true;
            rbUpperCase.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            rbUpperCase.CheckedState.BorderThickness = 0;
            rbUpperCase.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            rbUpperCase.CheckedState.InnerColor = Color.White;
            rbUpperCase.CheckedState.InnerOffset = -4;
            rbUpperCase.ForeColor = SystemColors.Control;
            rbUpperCase.Location = new Point(28, 42);
            rbUpperCase.Name = "rbUpperCase";
            rbUpperCase.Size = new Size(106, 24);
            rbUpperCase.TabIndex = 0;
            rbUpperCase.TabStop = true;
            rbUpperCase.Text = "Upper Case";
            rbUpperCase.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rbUpperCase.UncheckedState.BorderThickness = 2;
            rbUpperCase.UncheckedState.FillColor = Color.Transparent;
            rbUpperCase.UncheckedState.InnerColor = Color.Transparent;
            rbUpperCase.UseVisualStyleBackColor = false;
            // 
            // rbTitleCase
            // 
            rbTitleCase.AutoSize = true;
            rbTitleCase.BackColor = Color.FromArgb(35, 35, 35);
            rbTitleCase.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            rbTitleCase.CheckedState.BorderThickness = 0;
            rbTitleCase.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            rbTitleCase.CheckedState.InnerColor = Color.White;
            rbTitleCase.CheckedState.InnerOffset = -4;
            rbTitleCase.ForeColor = SystemColors.Control;
            rbTitleCase.Location = new Point(28, 106);
            rbTitleCase.Name = "rbTitleCase";
            rbTitleCase.Size = new Size(94, 24);
            rbTitleCase.TabIndex = 2;
            rbTitleCase.Text = "Title Case";
            rbTitleCase.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rbTitleCase.UncheckedState.BorderThickness = 2;
            rbTitleCase.UncheckedState.FillColor = Color.Transparent;
            rbTitleCase.UncheckedState.InnerColor = Color.Transparent;
            rbTitleCase.UseVisualStyleBackColor = false;
            rbTitleCase.CheckedChanged += rbTitleCase_CheckedChanged;
            // 
            // frmStanderizeCase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(276, 208);
            Controls.Add(rbTitleCase);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(rbLoweCAse);
            Controls.Add(rbUpperCase);
            ForeColor = Color.Coral;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmStanderizeCase";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmStanderizeCase";
            Load += frmStanderizeCase_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2RadioButton rbLoweCAse;
        private Guna.UI2.WinForms.Guna2RadioButton rbUpperCase;
        private Guna.UI2.WinForms.Guna2RadioButton rbTitleCase;
    }
}