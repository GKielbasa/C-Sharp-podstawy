using zad8.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Wektor v1 = new Wektor(3, new double[] { 1, 2, 3 });
        Wektor v2 = new Wektor(3, new double[] { 4, 5, 6 });

        Console.WriteLine("v1:");
        v1.show();
        Console.WriteLine($"Suma v1: {v1.Suma()}");
        Console.WriteLine("v2:");
        v2.show();
        Console.WriteLine($"Max: {v2.Max()}"); 
        Console.WriteLine($"Srednia: {v2.Srednia()}"); 
    }
}