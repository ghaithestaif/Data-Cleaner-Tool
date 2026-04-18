using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Cleaning_Layer
{
    public class clsStanderizeCasingFeature:ICleaningFeature
    {
        clsSchema _Schema;
        clsConfiguration _Config;
        HashSet<int> _stringColumnsIndexes;
        public clsStanderizeCasingFeature(clsConfiguration Config,clsSchema Schema)
        {
            _Config = Config;
            _Schema = Schema;
            PrepareOptionAction();
            _stringColumnsIndexes = getStringColumnsIndexes();
        }
        Func<string, string> _handleCasingStandard;
        void PrepareOptionAction()
            {
            if (_Config.StanderdizeDataOption == clsConfiguration.enCasingStanderdizationOption.TitleCase)
            {
                _handleCasingStandard = (input) =>
                {
                    return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
                };
            }
            else if (_Config.StanderdizeDataOption == clsConfiguration.enCasingStanderdizationOption.UpperCase)
            {
                _handleCasingStandard = (input) => { return input.ToUpper(); };
            }
            else if (_Config.StanderdizeDataOption == clsConfiguration.enCasingStanderdizationOption.LowerCase)
            {
                _handleCasingStandard = (input) => { return input.ToLower(); };
            }
            else
            {
                throw new InvalidOperationException("Invalid Casing option.");
            }

        }
        HashSet<int> getStringColumnsIndexes()
        {
            HashSet<int> stringColumnsIndexes = new HashSet<int>();
            foreach (var column in _Schema.Columns)
            {
                if (column.DataType == clsColumnSchema.enDataType.String)
                {
                    stringColumnsIndexes.Add(column.ID);
                }
            }
            return stringColumnsIndexes;
        }

        public void Apply(List<List<string>> data)
        {
         
            for (int i = 0; i < data.Count; i++)
            {
                var row = data[i];

                for (int j = 0; j < row.Count ; j++)
                {
                    if(_stringColumnsIndexes.Contains(_Schema.GetColumnByIndex(j).ID)&&!string.IsNullOrEmpty(row[j]))
                    {
                        row[j] = _handleCasingStandard(row[j]);
                    }
                }
            }
        }
    }
}
