using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseOne;
class Program
{
    static void Main(string[] args)
    {
        List<string> names = GetList();
        List<string> result = GetNames(names);
        ForEach(result, n => Console.WriteLine(n));
        Console.ReadKey();
    }

    static void ForEach<T>(IEnumerable<T> collection, Action<T> action)
    {
        foreach (T item in collection)
        {
            action(item);
        }
    }

    static List<string> GetNames(List<string> names)
    {

        List<string> result = new List<string>();

        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y',
                          'A', 'E', 'I', 'O', 'U', 'Y' };

        result = names
            .Where(n =>
            n.Length > 4 &&
            vowels.Contains(n[^1]) &&
            char.IsUpper(n[0]))
            .ToList();

        return result;

    }

    static List<string> GetList()
    {
        List<string> list = Console
            .ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        return list;
    }
}
