Console.WriteLine("Enter array with ',': ");
var inputData = Console.ReadLine();
var data = inputData.Split(',');
Console.WriteLine($"Start array: {string.Join(',', data)}");    

const int maxCharLength = 3;
var outArr = new List<string>(data.Length);

foreach (var element in data)
{
    if (element.Length <= maxCharLength)
    {
        outArr.Add(element);
    }
}

Console.WriteLine($"Final array: {string.Join(',', outArr)}");