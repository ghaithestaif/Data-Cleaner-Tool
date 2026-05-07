using Cleaning_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cleaning_Layer.clsConfiguration;

namespace Data_Clean_Tool.Features
{
    public partial class frmEmptyNullReplace : Form
    {
        public frmEmptyNullReplace()
        {
            InitializeComponent();
        }

        private void frmEmptyNullReplace_Load(object sender, EventArgs e)
        {
            btnSave.Focus();
        }




        public clsConfiguration.enReplaceOption? SelectedOption { get; private set; } = enReplaceOption.DefaultValue;

        private void rbReplaceWithDefualtValue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRemoveRow.Checked)
            {
                SelectedOption = clsConfiguration.enReplaceOption.RemoveRow;
            }
            else if (rbReplaceWithDefualtValue.Checked)
            {
                SelectedOption = clsConfiguration.enReplaceOption.DefaultValue;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
