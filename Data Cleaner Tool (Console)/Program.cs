







// See https://aka.ms/new-console-template for more information
using Cleaning_Layer;

clsConfiguration config = new clsConfiguration
{
    FilePath = "D:\\Users\\GhaithEstaif\\Desktop\\myCSV.csv",
    RemoveDuplicates = true,
    HandleMissingValues = true,
    StandardizeData = true,
    ReplaceOption = clsConfiguration.enReplaceOption.DefaultValue
};





clsSchema schema = new clsSchema();
schema.AddColumn(new clsColumnSchema(0, "Name", clsColumnSchema.enDataType.String,true));
schema.AddColumn(new clsColumnSchema(1, "Age", clsColumnSchema.enDataType.Integer,true));
schema.AddColumn(new clsColumnSchema(2, "Date", clsColumnSchema.enDataType.DateTime,true));
schema.AddColumn(new clsColumnSchema(3, "score", clsColumnSchema.enDataType.Double,true));


clsClean clsClean = new clsClean(config, schema);
clsClean.Clean();
//print the cleaned data
clsClean.Data.ForEach(row =>
{
    Console.WriteLine(string.Join(", ", row));
});

// Print the cleaned data









