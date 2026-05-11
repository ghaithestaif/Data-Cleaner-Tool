namespace Data_Clean_Tool
{
    partial class frmMessage
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
            pbIcon = new PictureBox();
            lblMessage = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            SuspendLayout();
            // 
            // pbIcon
            // 
            pbIcon.Location = new Point(20, 30);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(64, 64);
            pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcon.TabIndex = 0;
            pbIcon.TabStop = false;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.White;
            lblMessage.Location = new Point(100, 30);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(280, 64);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Message";
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.FromArgb(60, 60, 60);
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(90, 120);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(100, 35);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(60, 60, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(200, 120);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmMessage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(404, 178);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(lblMessage);
            Controls.Add(pbIcon);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMessage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Message";
            Load += frmMessage_Load;
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbIcon;
        private Label lblMessage;
        private Button btnOK;
        private Button btnCancel;
    }
}