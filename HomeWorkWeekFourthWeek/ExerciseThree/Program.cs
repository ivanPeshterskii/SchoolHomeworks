using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseThree;
class Program
{
    static void Main(string[] args)
    {
        List<string> words = GetList();
        List<string> result = GetWords(words);
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

    static List<string> GetWords(List<string> words)
    {

        List<string> result = new List<string>();

        result = words.Where(w =>
        w.Contains('a') &&
        w.Contains('x') is false &&
        w.Length > 3 && w.Length < 7
        ).ToList();

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

