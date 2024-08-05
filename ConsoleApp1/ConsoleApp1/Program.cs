// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Console.WriteLine("Hello, World!");
//string numbers = "1 2 -3  5";

////List<int> newList = new List<int>();

////string holderString = "";

////for (int i = 0; i < numbers.Length; i++)
////{
////    if (numbers[i] != ' ')
////    {
////        holderString += numbers[i]; 
////    }
////    if (numbers[i] == ' ' && holderString != "")
////    {
////        newList.Add(int.Parse(holderString));

////        holderString = "";
////    }
////}
////newList.Add(int.Parse(holderString));.

//List<int> stringToInt = numbers
//    .Split(' ')
//    .Select(x => int.Parse(x))
//    .ToList();

//int maxValue = stringToInt.Max();
//int minValue = stringToInt.Min();

//return $"{maxValue} {minValue}";


string str = "abcde";

if (str.Length % 2 != 0)
{
    str += "_";
}

char[] stringArray = str.ToArray();

string emptyString = "";

for (int i = 0; i < stringArray.Length; i++)
{
    emptyString += stringArray[i];

    if (i % 2 != 0 && i != stringArray.Length - 1)
    {
        emptyString += "|";
    }
}

string[] newStringArray = emptyString.Split("|");

return newStringArray;
int.TryParse