using System;
using zadanie16.Models;

namespace zadanie16
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupa g = new Grupa();

            g.DodajCzlonkaGrupy(new Osoba(1, "Jan Kowalski"));
            g.DodajCzlonkaGrupy(new Osoba(2, "Anna Nowak"));

            Console.WriteLine($"Obecny rozmiar grupy: {g.RozmiarGrupy}");

            g.RozmiarGrupy = 20;

            Console.WriteLine($"Nowy rozmiar grupy po zwiększeniu: {g.RozmiarGrupy}");

            g.RozmiarGrupy = 5;

            Console.WriteLine($"Nowy rozmiar grupy po zmniejszeniu: {g.RozmiarGrupy}");

            g.RozmiarGrupy = 1; 

            Console.WriteLine($"Rozmiar grupy po próbie zmniejszenia do 1: {g.RozmiarGrupy}");
        }
    }
}
