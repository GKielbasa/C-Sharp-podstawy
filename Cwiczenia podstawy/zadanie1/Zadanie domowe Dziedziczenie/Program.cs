using System;
using Zadanie_domowe_Dziedziczenie.Models;

namespace Zadanie_domowe_Dziedziczenie
{
    internal static class main
    {
        static void Main(string[] args)
        {
                                ////1.b)
            //Pudelko p1 = new Pudelko();
            //Pudelko p2 = new Pudelko();

            //p1.glebokosc = 20D; p1.szerokosc = 30D; p1.wysokosc = 40D; p1.kolor = "zielony";

            //p2.glebokosc = 10D; p2.szerokosc = 20D; p2.wysokosc = 30D; p2.kolor = "niebieski";

            //Console.WriteLine($"dane pudelka p1: \t Wysokosc: {p1.wysokosc}\tSzerokosc: {p1.szerokosc}" +
            //    $"\tglebokosc: {p1.glebokosc}\tkolor: {p1.kolor}");
            //Console.WriteLine();
            //Console.WriteLine($"dane pudelka p2: \t Wysokosc: {p2.wysokosc}\tSzerokosc: {p2.szerokosc}" +
            //    $"\tglebokosc: {p2.glebokosc}\tkolor: {p2.kolor}");

                        ////1.d) Sprawdź czy po utworzeniu konstruktora można utworzyć obiekt bez podania paramentów
            ////niemozna poniewaz niemamy konstruktroa bezargumentowego

                    ////1.e) Utwórz konstruktor bezargumentowy, użyj go do utworzenia obiektów.
            //Pudelko p3 = new Pudelko();

                    ////1.f)Utwórz obiekt pudełka pudelkoA z nadaniem wartości pól
            //Pudelko F1 = new Pudelko(30D,50D,20D,"czerwony");

                    ////1.g) Utwórz nowy obiekt pudełka pudelkoB i przypisz mu wartość pudełka pudelkoA
            //Pudelko pudelkoA = new Pudelko(20D, 30D, 40D, "czarny");
            //Pudelko pudelkoB = new Pudelko();
            ////pudelkoB = pudelkoA;
            //Console.WriteLine($"szer pudB = {pudelkoB.szerokosc}");
            //Console.WriteLine($"szer pudA = {pudelkoA.szerokosc}");
                    ////1.h) Zmień wartość szerokości pudelkaB, później sprawdź wartość szerokości pudelkaA.
            //pudelkoB.szerokosc = 100D;
            //Console.WriteLine($"szer pudA po zmienaie wartosci w pudB: {pudelkoA.szerokosc}");
                    ////1.j)Użyj konstruktor kopiujący do utworzenia pudełka pudelkoC (jako kopię pudelkoB).
            //Pudelko pudelkoC = new Pudelko(pudelkoB);
                    ////1.k) Zmień wartość szerokości pudelkoB, sprawdź szerokość wszystkich pudełek.
            //pudelkoA.szerokosc = 10D;
            //pudelkoB.szerokosc = 1000D;
            //Console.WriteLine($"szerokosc wszystkich pudelek: pudelkoA: {pudelkoA.szerokosc}" +
            //    $"\t pudelkoB: {pudelkoB.szerokosc}\t pudelkoC: {pudelkoC.szerokosc}");
            Pudelko temPudlo = new Pudelko(); // aby sprtawdzic czy licznik dziala 
            Pudelko pudelkoOstateczne = new Pudelko(10,20,30,"Szary");
            double objetoscPudelka = pudelkoOstateczne.obliczObjetosc();
            Console.WriteLine($"obj pudelka: {objetoscPudelka}");
            int ileJestPudelek = pudelkoOstateczne.zwrocLiczbePudelek();
            Console.WriteLine($"stworzonych zostalo : {ileJestPudelek} pudelek");

        }
    }
}
