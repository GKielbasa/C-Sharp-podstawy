using System;
using System.Text.RegularExpressions;
using zadanie8.Models;

namespace zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] dane = new double[] { 1.0, 2.0, 3.0, 4.0 };
            Wektor v1 = new Wektor(dane.Length, dane);
            Console.WriteLine("wektor v1: ");
            v1.show();

            Wektor v2 = new Wektor(dane);
            Console.WriteLine("Wektor v2: ");
            v2.show();

            Wektor v3 = new Wektor(5, 1.0, 10.0);
            Console.WriteLine("wektor v3");
            v3.show();
        }
    }
}