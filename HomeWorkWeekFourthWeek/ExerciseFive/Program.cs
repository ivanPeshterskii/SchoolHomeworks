using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseFive;
class Program
{
    static void Main(string[] args)
    {
        List<string> namesOne = Console
            .ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<string> namesTwo = Console
            .ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        namesOne.AddRange(namesTwo);

        namesOne.Where(n =>
        n.StartsWith('A') ||
        n.StartsWith('M') ||
        n.Length > 6
        ).ToList();

        namesOne.ForEach(n => Console.WriteLine(n));
        Console.ReadKey();
    }
}


