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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Data_Clean_Tool.Controls
{
    public partial class ctrDataGrid : UserControl
    {
        public ctrDataGrid()
        {
            InitializeComponent();
        }
        public bool HasData
        {
            get { return gridData.DataSource != null; }
        }
       public enum enStatus { loading, Cleaning , presentingData}
        enStatus _status;
        public enStatus status
        {
            get { return _status; }
            set
            {
                _status = value;

                switch (_status)
                {
                    case enStatus.loading:
                        gridData.DataSource = null;
                        llCleaning.Text = "Loading Data...";
                        break;

                    case enStatus.Cleaning:
                        gridData.DataSource = null;
                        llCleaning.Text = "Cleaning Data...";
                        break;

                    default:
                        llCleaning.Text = "";
                        break;
                }
            }
        }


        private void tabDetails_Click(object sender, EventArgs e)
        {

        }
        public void LoadData(clsClean Clean)
        {
            if(Clean == null || Clean.ReadOnlyData == null || Clean.Schema == null)
            {
                MessageBox.Show("No data to load.");
                return;
            }
            status = enStatus.presentingData;
            gridData.DataSource = Utility.clsUtility.ConvertListToDataTable(Clean.ReadOnlyData, Clean.Schema);



        }
        private void gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlTopAction_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndown_Click(object sender, EventArgs e)
        {
            gridData.Focus();
            SendKeys.Send("{DOWN}");
        }

        private void btnUp_Click_1(object sender, EventArgs e)
        {
            gridData.Focus();
            SendKeys.Send("{UP}");
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            gridData.Focus();
            SendKeys.Send("{LEFT}");
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            gridData.Focus();
            SendKeys.Send("{RIGHT}");
        }
    }
}
