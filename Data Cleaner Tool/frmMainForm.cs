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
                Text = "Ready",
                Location = new Point(10, 8),
                AutoSize = true,
                ForeColor = Color.DarkGray
            };
            pStatusBar.Controls.Add(lblStatusLeft);
            this.Controls.Add(pStatusBar);

            // 4. Right Side Panel (Accordion Container)
            Guna2Panel pSidePanel = new Guna2Panel
            {
                Dock = DockStyle.Right,
                Width = 220,
                BackColor = Color.FromArgb(35, 35, 35),
                BorderThickness = 1,
                BorderColor = Color.FromArgb(60, 60, 60),
                CustomBorderThickness = new Padding(1, 0, 0, 0)
            };
            this.Controls.Add(pSidePanel);

            // FlowLayoutPanel manages the vertical stacking
            FlowLayoutPanel flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                Padding = new Padding(5)
            };
            pSidePanel.Controls.Add(flowPanel);

            // --- INPUT MENU SECTION ---
            Guna2Button btnInputHeader = CreateHeaderButton("Input");
            Panel pnlInputOptions = CreateOptionsContainer(90); // Height needed for options
            
            Guna2Button btnFromFile = CreateOptionButton("From File", 5);
            Guna2Button btnFromClipboard = CreateOptionButton("From Clipboard", 45);
            pnlInputOptions.Controls.Add(btnFromFile);
            pnlInputOptions.Controls.Add(btnFromClipboard);

            btnInputHeader.Click += (s, e) => { pnlInputOptions.Visible = !pnlInputOptions.Visible; };

            flowPanel.Controls.Add(btnInputHeader);
            flowPanel.Controls.Add(pnlInputOptions);


            // --- CLEAN MENU SECTION ---
            Guna2Button btnCleanHeader = CreateHeaderButton("Clean");
            Panel pnlCleanOptions = CreateOptionsContainer(90); // Expand this height to fit more buttons!
            pnlCleanOptions.Visible = false; // Start collapsed
            
            Guna2Button btnRemoveDuplicates = CreateOptionButton("Remove Duplicates", 5);
            // You can add more cleanup option buttons here manually later:
            // Guna2Button btnOtherClean = CreateOptionButton("Handle Nulls", 45);
            pnlCleanOptions.Controls.Add(btnRemoveDuplicates);
            // pnlCleanOptions.Controls.Add(btnOtherClean);

            btnCleanHeader.Click += (s, e) => { pnlCleanOptions.Visible = !pnlCleanOptions.Visible; };

            flowPanel.Controls.Add(btnCleanHeader);
            flowPanel.Controls.Add(pnlCleanOptions);


            // --- OUTPUT MENU SECTION ---
            Guna2Button btnOutputHeader = CreateHeaderButton("Output");
            Panel pnlOutputOptions = CreateOptionsContainer(50); 
            pnlOutputOptions.Visible = false; // Start collapsed
            
            Guna2Button btnToFile = CreateOptionButton("To File", 5);
            pnlOutputOptions.Controls.Add(btnToFile);

            btnOutputHeader.Click += (s, e) => { pnlOutputOptions.Visible = !pnlOutputOptions.Visible; };

            flowPanel.Controls.Add(btnOutputHeader);
            flowPanel.Controls.Add(pnlOutputOptions);


            // Add a splitter to allow users to resize the right side panel
            Splitter rightSplitter = new Splitter
            {
                Dock = DockStyle.Right,
                Width = 3,
                BackColor = Color.FromArgb(45, 45, 45) 
            };
            this.Controls.Add(rightSplitter);

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

            // Setup proper Z-ordering
            pMainArea.BringToFront();
            rightSplitter.BringToFront();
            pSidePanel.BringToFront();
            pToolbar.BringToFront();
            menuStrip.BringToFront();
        }

        // Helper: Creates the main category toggle buttons (Input, Clean, Output)
        private Guna2Button CreateHeaderButton(string text)
        {
            return new Guna2Button
            {
                Text = text,
                Width = 200, 
                Height = 40,
                BorderRadius = 5,
                FillColor = Color.FromArgb(50, 50, 50),
                HoverState = { FillColor = Color.FromArgb(70, 70, 70) },
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                TextAlign = HorizontalAlignment.Left,
                TextOffset = new Point(10, 0),
                Margin = new Padding(0, 10, 0, 5) // Adds space between categories
            };
        }

        // Helper: Creates the hidden container panel to hold the sub-buttons
        private Panel CreateOptionsContainer(int height)
        {
            return new Panel
            {
                Width = 200,
                Height = height, 
                BackColor = Color.Transparent,
                Margin = new Padding(0, 0, 0, 0)
            };
        }

        // Helper: Creates the sub-buttons (From File, To File, etc.)
        private Guna2Button CreateOptionButton(string text, int yPosition)
        {
            return new Guna2Button
            {
                Text = text,
                Location = new Point(10, yPosition),
                Width = 180, 
                Height = 35,
                BorderRadius = 17, // Pill shape
                BorderThickness = 1,
                BorderColor = Color.Gray,
                FillColor = Color.FromArgb(40, 40, 40),
                HoverState = { FillColor = Color.FromArgb(60, 60, 60) },
                ForeColor = Color.LightGray,
                Font = new Font("Segoe UI", 9F),
                TextAlign = HorizontalAlignment.Left,
                TextOffset = new Point(10, 0)
            };
        }
    }
}
