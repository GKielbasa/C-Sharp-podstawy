using System;
using zadanie5.Models;
class Program
{
    static void Main(string[] args)
    {
        Wielomian w1 = new Wielomian(3, new double[] { 1, 2, 3 });
        Console.WriteLine("show: ");
        w1.show();
        Console.WriteLine();
        Console.WriteLine();
        double wartoscWielomianuWPX = w1.DajWartosc(2);
        Console.WriteLine($"ile: {wartoscWielomianuWPX}");       
    }
}