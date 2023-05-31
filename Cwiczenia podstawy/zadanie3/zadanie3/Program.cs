using System;
using zadanie3.Models;

namespace Zadanie_domowe_Dziedziczenie
{
    internal static class main
    {
        static void Main(string[] args)
        {
          double[] dane1 = {1, 2, 3};
          double[] dane2 = {3, 4, 5};
          Wektor w1 = new Wektor(3,dane1);
          Wektor w2 =new Wektor(3,dane2);

            //show 
            w1.show();
            Console.WriteLine();
            w2.show();

            // suma
            Console.Write($"Suma współrzędnych wektora: {w1.SumujWspolrzedne()}");

            //dodawnaie wektorów
            Wektor w3 = w1.Add(w2);
            Console.WriteLine("suma wektorów w1 + w1: ");
            w3.show();

        }
    }
}
