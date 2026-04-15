using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Layer
{
    public interface ICleaningFeature
    {
        void Apply( List<List<string>> data);
    }

}
