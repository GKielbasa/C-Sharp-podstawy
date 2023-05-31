using System;
using zadanie1.Models;
class Program
{
    static void Main(string[] args)
    {
        //podpunkt a 
        LiczbaZespolona z1 = new LiczbaZespolona(3, 2);
        LiczbaZespolona z2 = new LiczbaZespolona(1, 7);

        LiczbaZespolona wynik = LiczbaZespolona.Dodaj(z1,z2);

        Console.WriteLine($"wynik dodawania: {wynik.re} + {wynik.im}");
        wynik = LiczbaZespolona.Odejmij(z1,z2);
        Console.WriteLine($"wynik odejmowania: {wynik.re} + {wynik.im}");
        wynik = LiczbaZespolona.Pomnoz(z1 ,z2);
        Console.WriteLine($"wynik mnożenia: {wynik.re} + {wynik.im}");
        wynik = LiczbaZespolona.Podziel(z1 ,z2);
        Console.WriteLine($"wynik dzielenia: {wynik.re} + {wynik.im}");

        //Przeciążenia 
        Console.WriteLine("Przeciazenia :");
        wynik = z1 + z2;
        Console.WriteLine($"Wynik dodawania: {wynik.re} + {wynik.im}");
        wynik = z1 - z2;
        Console.WriteLine($"Wynik odejmownaia: {wynik.re} + {wynik.im}");
        wynik = z1 * z2;
        Console.WriteLine($"Wynik mnożenia: {wynik.re} + {wynik.im}");
        wynik = z1 / z2;
        Console.WriteLine($"Wynik dzilenia: {wynik.re} + {wynik.im}");
        Console.WriteLine();
        //odwracanie liczny zespolonej 
        Console.WriteLine("odwr liczba ");
        wynik = -z1;
        Console.WriteLine($"z1: {z1.re} + {z1.im} | -z1: {wynik.re} + {wynik.im}");
    }
}
