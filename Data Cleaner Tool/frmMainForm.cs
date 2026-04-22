using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Data_Cleaner_Tool
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // Form basic settings
            this.Text = "Data Cleaner Tool";
            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(800, 600);
            this.BackColor = Color.FromArgb(30, 30, 30); // Main Dark background
            this.ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // 1. Menu Strip (Top)
            MenuStrip menuStrip = new MenuStrip
            {
                BackColor = Color.FromArgb(40, 40, 40),
                ForeColor = Color.LightGray,
                RenderMode = ToolStripRenderMode.System
            };
            menuStrip.Items.Add("File");
            menuStrip.Items.Add("Edit");
            menuStrip.Items.Add("Run");
            menuStrip.Items.Add("View");
            menuStrip.Items.Add("Licensing");
            menuStrip.Items.Add("Help");
            this.Controls.Add(menuStrip);
            this.MainMenuStrip = menuStrip;

            // 2. Toolbar Panel (Below Menu)
            Guna2Panel pToolbar = new Guna2Panel
            {
                Dock = DockStyle.Top,
                Height = 40,
                BackColor = Color.FromArgb(45, 45, 45),
                BorderThickness = 1,
                BorderColor = Color.FromArgb(60, 60, 60),
                CustomBorderThickness = new Padding(0, 0, 0, 1)
            };
            this.Controls.Add(pToolbar);

            // 3. Status Bar Panel (Bottom)
            Guna2Panel pStatusBar = new Guna2Panel
            {
                Dock = DockStyle.Bottom,
                Height = 30,
                BackColor = Color.FromArgb(45, 45, 45),
                BorderThickness = 1,
                BorderColor = Color.FromArgb(60, 60, 60),
                CustomBorderThickness = new Padding(0, 1, 0, 0)
            };
            
            Label lblStatusLeft = new Label
            {
                Text = "Open an existing .transform document. (Ctrl+O)",
                Location = new Point(10, 8),
                AutoSize = true,
                ForeColor = Color.DarkGray
            };
            pStatusBar.Controls.Add(lblStatusLeft);
            this.Controls.Add(pStatusBar);

            // 4. Input Side Panel (Left)
            Guna2Panel pSidePanel = new Guna2Panel
            {
                Dock = DockStyle.Left,
                Width = 200,
                BackColor = Color.FromArgb(35, 35, 35),
                BorderThickness = 1,
                BorderColor = Color.FromArgb(60, 60, 60),
                CustomBorderThickness = new Padding(0, 0, 1, 0)
            };

            // Input Header Label
            Label lblInputHeader = new Label
            {
                Text = "Input",
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 30,
                ForeColor = Color.FromArgb(180, 100, 180), // Purple-ish text
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            pSidePanel.Controls.Add(lblInputHeader);

            // From File Button
            Guna2Button btnFromFile = CreateSideButton("From File", 40);
            pSidePanel.Controls.Add(btnFromFile);

            // From Clipboard Button
            Guna2Button btnFromClipboard = CreateSideButton("From Clipboard", 85);
            pSidePanel.Controls.Add(btnFromClipboard);

            this.Controls.Add(pSidePanel);

            // Add a splitter to allow users to resize the left side panel
            Splitter leftSplitter = new Splitter
            {
                Dock = DockStyle.Left,
                Width = 3,
                BackColor = Color.FromArgb(45, 45, 45) // Match toolbar/border color
            };
            this.Controls.Add(leftSplitter);

            // 5. Main Content Area (Fill)
            Guna2Panel pMainArea = new Guna2Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(30, 30, 30),
                AllowDrop = true
            };

            Label lblDropData = new Label
            {
                Text = "ADD YOUR DATA\ndrag files here; or\nclick [From File] or [From Clipboard] buttons",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 11F)
            };
            pMainArea.Controls.Add(lblDropData);
            this.Controls.Add(pMainArea);

            // Setup proper Z-ordering so docking works: 
            // The last added control docks to edges first. Reverse z-order fixing.
            pMainArea.BringToFront();
            leftSplitter.BringToFront();
            pSidePanel.BringToFront();
            pToolbar.BringToFront();
            menuStrip.BringToFront();
        }

        private Guna2Button CreateSideButton(string text, int yPosition)
        {
            return new Guna2Button
            {
                Text = text,
                Location = new Point(10, yPosition),
                Width = 180, // Expand width to maintain a 10px margin on both sides (200 panel width - 20)
                Height = 35,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right, // Allows controls to scale horizontally
                BorderRadius = 17, // Rounded pill shape
                BorderThickness = 1,
                BorderColor = Color.Gray,
                FillColor = Color.FromArgb(40, 40, 40),
                HoverState = { FillColor = Color.FromArgb(60, 60, 60) },
                ForeColor = Color.LightGray,
                TextAlign = HorizontalAlignment.Left,
                TextOffset = new Point(10, 0)
            };
        }
    }
}
