







// See https://aka.ms/new-console-template for more information
using Cleaning_Layer;

clsConfiguration config = new clsConfiguration
{
    FilePath = "D:\\Users\\GhaithEstaif\\Desktop\\myCSV.csv",
    StandardizeData = true,
    ReplaceOption = clsConfiguration.enReplaceOption.DefaultValue,
    StanderdizeDataOption = clsConfiguration.enCasingStanderdizationOption.UpperCase
   
};






clsClean clsClean = new clsClean(config);
clsClean.Clean();
//print the cleaned data
clsClean.Data.ForEach(row =>
{
    Console.WriteLine(string.Join(", ", row));
}
);

// Print the cleaned data









