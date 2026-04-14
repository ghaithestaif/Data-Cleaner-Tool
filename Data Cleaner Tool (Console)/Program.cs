







// See https://aka.ms/new-console-template for more information
using Cleaning_Layer;

clsConfiguration config = new clsConfiguration
{
    FilePath = "D:\\Users\\GhaithEstaif\\Desktop\\my.xlsx",
    RemoveDuplicates = true,
    HandleMissingValues = true,
    StandardizeData = true
};
clsClean clsClean = new clsClean(config);
// Print the cleaned data









