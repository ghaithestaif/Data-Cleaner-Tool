using System;
using System.Linq;
using System.Windows.Forms;
using Cleaning_Layer.Report_Classes;

namespace Data_Clean_Tool
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
            LoadReportData();
        }

        private void LoadReportData()
        {
            var reports = clsFeatureReportManager.FeaturesReports.ToList();

            if (reports == null || reports.Count == 0)
            {
                this.dgvReport.DataSource = null;
                return;
            }

            this.dgvReport.DataSource = reports;

            if (this.dgvReport.Columns["Feature"] != null) {
                this.dgvReport.Columns["Feature"].HeaderText = "Applied Feature";
                this.dgvReport.Columns["Feature"].Width = 175;


            }


            if (this.dgvReport.Columns["RemovedRecordsAffected"] != null)
            {
                this.dgvReport.Columns["RemovedRecordsAffected"].HeaderText = "Removed Records";
                this.dgvReport.Columns["RemovedRecordsAffected"].Width = 175;
            }
            if (this.dgvReport.Columns["UpdatedRecordsAffected"] != null)
            {   
                this.dgvReport.Columns["UpdatedRecordsAffected"].HeaderText = "Updated Records";
                this.dgvReport.Columns["UpdatedRecordsAffected"].Width = 175;
            }
            if (this.dgvReport.Columns["RecordsAffected"] != null)
            {
                this.dgvReport.Columns["RecordsAffected"].HeaderText = "Total Affected";
                this.dgvReport.Columns["RecordsAffected"].Width = 175;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }
    }
}