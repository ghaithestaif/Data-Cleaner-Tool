namespace Data_Clean_Tool
{
    partial class frmReport
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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitle = new Label();
            btnClose = new Button();
            dgvReport = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Gray;
            lblTitle.Location = new Point(23, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(423, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Data Cleaning Summary Report";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(224, 224, 224);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F);
            btnClose.Location = new Point(571, 440);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 53);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dgvReport
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 40);
            dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvReport.BackgroundColor = Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReport.ColumnHeadersHeight = 30;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(76, 132, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReport.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReport.GridColor = Color.FromArgb(50, 50, 50);
            dgvReport.Location = new Point(12, 76);
            dgvReport.Margin = new Padding(3, 4, 3, 4);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersVisible = false;
            dgvReport.RowHeadersWidth = 51;
            dgvReport.RowTemplate.Height = 25;
            dgvReport.Size = new Size(701, 340);
            dgvReport.TabIndex = 3;
            dgvReport.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvReport.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvReport.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvReport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvReport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvReport.ThemeStyle.BackColor = Color.FromArgb(35, 35, 35);
            dgvReport.ThemeStyle.GridColor = Color.FromArgb(50, 50, 50);
            dgvReport.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvReport.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReport.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvReport.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvReport.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvReport.ThemeStyle.HeaderStyle.Height = 30;
            dgvReport.ThemeStyle.ReadOnly = true;
            dgvReport.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(45, 45, 45);
            dgvReport.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReport.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvReport.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvReport.ThemeStyle.RowsStyle.Height = 25;
            dgvReport.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(76, 132, 255);
            dgvReport.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(725, 508);
            Controls.Add(dgvReport);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmReport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cleaning Report";
            Load += frmReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReport;
    }
}