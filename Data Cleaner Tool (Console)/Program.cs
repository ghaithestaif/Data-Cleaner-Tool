







// See https://aka.ms/new-console-template for more information
using Cleaning_Layer;

clsConfiguration config = new clsConfiguration
{
    FilePath = "D:\\Users\\GhaithEstaif\\Desktop\\myCSV.csv",
    StandardizeData = true,
    ReplaceOption = clsConfiguration.enReplaceOption.DefaultValue,
    StanderdizeDataOption = clsConfiguration.enCasingStanderdizationOption.UpperCase
   
};





clsSchema schema = new clsSchema();
schema.AddColumn(new clsColumnSchema("Name", clsColumnSchema.enDataType.String,true));
schema.AddColumn(new clsColumnSchema("Age", clsColumnSchema.enDataType.Integer,true));
schema.AddColumn(new clsColumnSchema("Date", clsColumnSchema.enDataType.DateTime,true));
schema.AddColumn(new clsColumnSchema("score", clsColumnSchema.enDataType.Double,true));
schema.AddColumn(new clsColumnSchema("Name", clsColumnSchema.enDataType.String, true));


clsClean clsClean = new clsClean(config, schema);
clsClean.Clean();
//print the cleaned data
clsClean.Data.ForEach(row =>
{
    Console.WriteLine(string.Join(", ", row));
});

// Print the cleaned data









