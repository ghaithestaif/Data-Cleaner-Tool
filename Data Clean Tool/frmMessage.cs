using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Clean_Tool
{
    public partial class frmMessage : Form
    {
        public enum enMessageState { Error = 1, Information = 2, Warning = 3, Succeed=4 }

        private enMessageState _State;
        private string _Message;

        public frmMessage(enMessageState state, string message)
        {
            InitializeComponent();
            _State = state;
            _Message = message;
            _LoadMessage();
        }

        private void _LoadMessage()
        {
            lblMessage.Text = _Message;

            switch (_State)
            {
                case enMessageState.Error:
                    pbIcon.Image = SystemIcons.Error.ToBitmap();
                    this.Text = "Error";
                    btnCancel.Visible = false;
                    btnOK.Location = new Point((this.Width - btnOK.Width) / 2, btnOK.Location.Y);
                    break;
                case enMessageState.Information:
                    pbIcon.Image = SystemIcons.Information.ToBitmap();
                    this.Text = "Information";
                    btnCancel.Visible = false;
                    btnOK.Location = new Point((this.Width - btnOK.Width) / 2, btnOK.Location.Y);
                    break;
                case enMessageState.Warning:
                    pbIcon.Image = SystemIcons.Warning.ToBitmap();
                    this.Text = "Warning";
                    btnCancel.Visible = true;
                    // Reset positions if originally they were meant to be side by side
                    btnOK.Location = new Point(this.Width / 2 - btnOK.Width - 10, btnOK.Location.Y);
                    btnCancel.Location = new Point(this.Width / 2 + 10, btnCancel.Location.Y);
                    break;
                case enMessageState.Succeed:
                    pbIcon.Image = SystemIcons.WinLogo.ToBitmap();
                    this.Text = "Succeeded";
                    btnCancel.Visible = false;
                    btnOK.Location = new Point((this.Width - btnOK.Width) / 2, btnOK.Location.Y);
                    break;
            }
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public frmMessage()
        {
            InitializeComponent();
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
