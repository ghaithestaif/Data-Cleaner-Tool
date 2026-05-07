using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Clean_Tool.Features
{
    public partial class frmRowsIgnore : Form
    {
        public frmRowsIgnore()
        {
            InitializeComponent();
        }

        private void frmRowsIgnore_Load(object sender, EventArgs e)
        {

        }
        public int selectedRowCount { get { return int.TryParse(btnNumberOfRows.Text, out int result) ? result : 0; } }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
