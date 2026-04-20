using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Layer.Report_Classes
{
    public class clsFeatureReportManager
    {
       static List<clsFeatureReport> _featureReports = new List<clsFeatureReport>();

        
        static public IReadOnlyList<clsFeatureReport> clsFeatureName => _featureReports.AsReadOnly(); 

        static   public void AddFeatureReport(clsFeatureReport report)
        {
            _featureReports.Add(report);
        }




    }
}
