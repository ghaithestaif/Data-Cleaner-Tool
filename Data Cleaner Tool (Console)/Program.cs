







// See https://aka.ms/new-console-template for more information
using Cleaning_Layer;

clsConfiguration config = new clsConfiguration
{
    FilePathwithFileName = "D:\\Users\\GhaithEstaif\\Desktop\\my.xlsx",
    StandardizeData = true,
    HandleMissingValues = true,
    ReplaceOption = clsConfiguration.enReplaceOption.DefaultValue

};






clsClean clsClean = new clsClean(config);
clsClean.Clean();
//print the cleaned data
foreach (var row in clsClean.ReadOnlyData)
{
    Console.WriteLine(string.Join(", ", row));
}
// Print the cleaned data









