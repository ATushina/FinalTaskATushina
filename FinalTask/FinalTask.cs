// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.

string[] Array = InputArray();
string[] resultArray = NewArray(Array);
string first = WriteArray(Array);
string second = WriteArray(resultArray);
Console.WriteLine(first + " --> " + second);

string[] InputArray()
{
    Console.WriteLine("Введите слова через пробел, нажмите Enter: ");
    string? Symbols = Console.ReadLine();
    if (Symbols == null) {Symbols = "";};
    char[] separators = new char[] { ',', ' ' };
    string[] Array = Symbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return Array;
}

string WriteArray(string[] Array)
{
    string stringArray = "[";
    for (int i = 0; i < Array.Length; i++)
    {
        if (i == Array.Length - 1)
        {
            stringArray += $"\"{Array[i]}\"";
            break;
        }
        stringArray += ($"\"{Array[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}

int CountStringSymbols(string[] Array)
{
    int counter = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] NewArray(string[] Array)
{
    int resultArrayLength = CountStringSymbols(Array);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string word in Array)
    {
        if (word.Length <= 3)
        {
            resultArray[i] = word;
            i++;
        }
    }
    return resultArray;
}