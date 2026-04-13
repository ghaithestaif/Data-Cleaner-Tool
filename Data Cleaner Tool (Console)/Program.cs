







// See https://aka.ms/new-console-template for more information
List<List<string>> data = Cleaning_Layer.clsClean.CleanData("D:\\Users\\GhaithEstaif\\Desktop\\my.xlsx");


// Print the cleaned data

data.ForEach(row =>
{
    Console.WriteLine(string.Join(" ", row));
});







