// 


Console.Clear();
// using System;
// using static System.Console;
Console.WriteLine("Введите массив строк через пробел: ");
string str = Console.ReadLine();
string[] array = str.Split(' ');
//string[] array = new string {"hello" , "2" , "world", "like" , "Geek", "Brains", ":)" };
string[] arr = GetArray(array);
Console.WriteLine(String.Join(", ", arr));

string[] GetArray(string[] array)
{
    string[] result = new string [array.Length];
    int size = 3; 
    if (array.Length < size)
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i];
    } 
    return result;
}

