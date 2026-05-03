using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Data_Clean_Tool.Controls
{
    public partial class ctrSheetCard : UserControl
    {
        public event Action<string> SheetSelected;
        private string _sheetName;

        private Guna2Panel panelBackground;
        private Label lblTitle;

        public ctrSheetCard(string sheetName)
        {
            InitializeComponent();
            _sheetName = sheetName;
            lblTitle.Text = sheetName;
            this.Tag = sheetName;
        }

        private void InitializeComponent()
        {
            this.panelBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();

            // panelBackground
            this.panelBackground.BorderColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.panelBackground.BorderRadius = 14;
            this.panelBackground.BorderThickness = 1;
            this.panelBackground.Controls.Add(this.lblTitle);
            this.panelBackground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.FillColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(160, 90);
            this.panelBackground.TabIndex = 0;
            this.panelBackground.Click += new System.EventHandler(this.OnCardClicked);
            this.panelBackground.MouseEnter += new System.EventHandler(this.OnCardMouseEnter);
            this.panelBackground.MouseLeave += new System.EventHandler(this.OnCardMouseLeave);

            // lblTitle
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 90);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sheet Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.OnCardClicked);
            this.lblTitle.MouseEnter += new System.EventHandler(this.OnCardMouseEnter);
            this.lblTitle.MouseLeave += new System.EventHandler(this.OnCardMouseLeave);

            // ctrSheetCard
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelBackground);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ctrSheetCard";
            this.Size = new System.Drawing.Size(160, 90);
            this.panelBackground.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void OnCardClicked(object sender, EventArgs e)
        {
            SheetSelected?.Invoke(_sheetName);
        }

        private void OnCardMouseEnter(object sender, EventArgs e)
        {
            panelBackground.FillColor = Color.FromArgb(55, 55, 55);
        }

        private void OnCardMouseLeave(object sender, EventArgs e)
        {
            panelBackground.FillColor = Color.FromArgb(40, 40, 40);
        }
    }
}