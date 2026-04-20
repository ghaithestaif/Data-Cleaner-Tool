using Cleaning_Layer.Report_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Layer.Features
{
    public interface ICleaningFeature
    {
        clsFeatureReport Apply( List<List<string>> data);
    }

}
