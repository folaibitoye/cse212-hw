using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Test MultiplesOf
        var result = Arrays.MultiplesOf(3, 5);
        Console.WriteLine("MultiplesOf(3, 5):");
        foreach (var m in result)
        {
            Console.Write($"{m} ");
        }
        Console.WriteLine("\n");

        // Test RotateListRight
        var data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Arrays.RotateListRight(data, 3);
        Console.WriteLine("Rotated List by 3:");
        foreach (var item in data)
        {
            Console.Write($"{item} ");
        }
    }
}
