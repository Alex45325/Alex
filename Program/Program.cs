using System;
using System.Collections.Generic;

class Program
{
    static List<string> FilterStrings(string[] arr)
    {
        List<string> result = new List<string>();
        foreach (string s in arr)
        {
            if (s.Length <= 3)
            {
                result.Add(s);
            }
        }
        return result;
    }

    static void Main()
    {
        // Введите массив строк с клавиатуры
        Console.Write("Введите строки через запятую: ");
        string inputStrings = Console.ReadLine();
        string[] originalArray = inputStrings.Split(", ");

        // Фильтрация строк
        List<string> filteredArray = FilterStrings(originalArray);

        // Вывод результата
        Console.WriteLine("Исходный массив: " + string.Join(", ", originalArray));
        Console.WriteLine("Отфильтрованный массив: " + string.Join(", ", filteredArray));
    }
}