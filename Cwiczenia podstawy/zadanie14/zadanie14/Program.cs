using System;
using zadanie14.Models;

namespace zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] wspolrzedne1 = { 1, 2, 3, 4, 5 };
            double[] wspolrzedne2 = { 5, 4, 3, 2, 1 };

            Wektor w1 = new Wektor(wspolrzedne1.Length, wspolrzedne1);
            Wektor w2 = new Wektor(wspolrzedne2.Length, wspolrzedne2);

            Console.WriteLine("Wektor 1:");
            w1.show();

            Console.WriteLine("Wektor 2:");
            w2.show();

            Console.WriteLine($"Suma współrzędnych wektora 1: {w1.SumujWspolrzedne()}");
            Console.WriteLine($"Suma współrzędnych wektora 2: {w2.SumujWspolrzedne()}");

            Wektor w3 = w1.Add(w2);

            Console.WriteLine("Wektor 3 (suma wektorów 1 i 2):");
            w3.show();

            Console.WriteLine($"Wartość na 2 pozycji wektora 3 przed zmianą: {w3[2]}");
            w3[2] = 10;
            Console.WriteLine($"Wartość na 2 pozycji wektora 3 po zmianie: {w3[2]}");

            try
            {
                double val = w3[10]; 
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}