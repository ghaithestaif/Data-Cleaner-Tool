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

namespace Data_Clean_Tool.Features
{
    public partial class frmStanderizeCase : Form
    {

        public frmStanderizeCase()
        {
            InitializeComponent();
        }



        public clsConfiguration.enCasingStanderdizationOption? SelectedOption
        {
            get
            {
                return (rbLoweCAse.Checked) ? clsConfiguration.enCasingStanderdizationOption.LowerCase :
                       (rbUpperCase.Checked) ?
                       clsConfiguration.enCasingStanderdizationOption.UpperCase :
                       (rbTitleCase.Checked) ?
                       clsConfiguration.enCasingStanderdizationOption.TitleCase : null;
            }
        }

        private void frmStanderizeCase_Load(object sender, EventArgs e)
        {
            btnSave.Focus();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rbTitleCase_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
