using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseTwo;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = GetList();
        List<int> result = GetNumbers(numbers);
        ForEach(result, r => Console.WriteLine(r));
        Console.ReadKey();
    }
    static void ForEach<T>(IEnumerable<T> collection, Action<T> action)
    {
        foreach (T item in collection)
        {
            action(item);
        }
    }

    static List<int> GetNumbers(List<int> numbers)
    {

        List<int> result = new List<int>();

        result = numbers
            .Where(n =>
            n > 0 ||
            n % 2 == 0 ||
            n % 7 == 0)
            .ToList();

        return result;

    }

    static List<int> GetList()
    {
        List<int> list = Console
            .ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        return list;
    }
}

