using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseFour;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = GetList();
        List<int> numbersTwo = GetList();

        List<int> result = GetNumbers(numbers, numbersTwo);

        ForEach(result, r => Console.WriteLine(r));

    }

    static void ForEach<T>(IEnumerable<T> collection, Action<T> action)
    {
        foreach (T item in collection)
        {
            action(item);
        }
    }

    static List<int> GetNumbers(List<int> numbersOne, List<int> numbersTwo)
    {
        double average = numbersTwo.Average();

        List<int> result = numbersOne
            .Where(i => numbersTwo.Contains(i) &&
            i > average)
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

