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



        private void tabDetails_Click(object sender, EventArgs e)
        {

        }
        public void LoadData(clsClean Clean)
        {
            gridData.DataSource = Utility.clsUtility.ConvertListToDataTable(Clean.Data);


        }
        private void gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }
    }
}
