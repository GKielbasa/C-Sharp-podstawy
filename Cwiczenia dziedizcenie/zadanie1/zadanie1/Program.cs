using System;
using zadanie1.Models;
class Program
{
    static void Main(string[] args)
    {
        Samochod s1 = new Samochod("testKlasyBazowej",2000,200000,"Jan Kowalski");
        Console.WriteLine("samochod s1:");
        s1.Wypisz();
        Console.WriteLine();

        Osobowy o1 = new Osobowy(5, 200, "audi", 2000, 200000, "Jozin z Bazin");
        Osobowy o2 = new Osobowy(5, 200, "fiat", 1000, 2034500, "Jozin z Bazin");
        Console.WriteLine("osobowy o1:");
        o1.Wypisz();
        Console.WriteLine();

        Ciezarowy c1 = new Ciezarowy(2000, 2000, "Kamaz", 2000, 200000, "Mosiek Czesiek");
        Ciezarowy c2 = new Ciezarowy(2000, 2000, "volvo", 2000, 200000, "Mosiek Czesiek");
        Ciezarowy c3 = new Ciezarowy(2000, 2000, "man", 2000, 200000, "Mosiek Czesiek");
        Console.WriteLine("ciezarowy c1");
        c1 .Wypisz();

        int liczbaSamochodow = Samochod.LiczbaSamochodowOgolnie;
        int liczbaOsobowych = Osobowy.LiczbaSamochodowOsobowych;
        int liczbaCiezarowych = Ciezarowy.LiczbaSamochodowCiezarowych;

        Console.WriteLine($"liczba osobowych: {liczbaOsobowych}\nliczba ciezarowych: {Ciezarowy.LiczbaSamochodowCiezarowych}\nogolna liczba samochodow: {Osobowy.LiczbaSamochodowOsobowych}");

    }
}