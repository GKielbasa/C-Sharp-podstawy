using System;
using zadanie2.Models;

namespace Zadanie_domowe_Dziedziczenie
{
    internal static class main
    {
        static void Main(string[] args)
        {
            Punkt a = new Punkt(6D,7D);
            Punkt b = new Punkt(11D,9D);

            Punkt c = new Punkt(2D, 3D);
            Punkt d = new Punkt(5D, 6D);

            //a.Wypisz();
            //b.Wypisz();

            Odcinek odcinek1 = new Odcinek(a,b);
            Odcinek odcinek2 = new Odcinek(c,d);

            Console.WriteLine("odcinek1:");
            odcinek1.wypiszOdcinek();

            //Console.WriteLine("odcinek2:");
            //odcinek2.wypiszOdcinek();

            //Console.WriteLine($"dlugosc odcinka 1: {odcinek1.Dlugosc()} ");

            Punkt nowyPoczatek = new Punkt(2, 3);
            Punkt nowyKoniec = new Punkt(5, 6);
            odcinek1.UstawNowyPunktPoczatkowy(nowyPoczatek);
            odcinek1.UstawNowyPunktKoncowy(nowyKoniec);

            Console.WriteLine("nowe wsp odcnika1: ");
            odcinek1.wypiszOdcinek();
        }
    }
}
