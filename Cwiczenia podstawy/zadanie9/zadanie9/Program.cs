using System;
using System.Numerics;
using zadanie9.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(RandomUtility.RandInt(1, 10));
        Console.WriteLine(RandomUtility.RandomDecimal(1m, 10m));
        Console.WriteLine(RandomUtility.RandDouble(1.0, 10.0));
        Console.WriteLine(RandomUtility.RandomString(10));

        int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var randomElements = RandomUtility.RandomFromArray(5, Array, false);
        foreach (var element in randomElements)
        {
            Console.WriteLine(element);
        }



    }
}