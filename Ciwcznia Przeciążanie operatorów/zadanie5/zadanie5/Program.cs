using zadanie5.Models;
using zadanie8;

class Program
{
    public static void Main(string[] args)
    {
        Osoba osoba1 = new Osoba(1, "Jan Kowalski", "123456789");
        Osoba osoba2 = new Osoba(2, "Anna Nowak", "987654321");
        Osoba osoba3 = new Osoba(3, "Piotr Nowak", "567891234");

        Grupa grupa = new Grupa();
        grupa.DodajOsobe(osoba1);
        grupa.DodajOsobe(osoba2);
        grupa.DodajOsobe(osoba3);

        Console.WriteLine("Grupa po dodaniu osób:");
        Console.WriteLine($"Liczba miejsc: {grupa.LiczbaMiejsc()}");
        Console.WriteLine($"Liczba osób: {grupa.LiczbaOsob()}");

        Console.WriteLine("\nUsunięcie osoby o ID = 2:");
        grupa -= osoba2;
        Console.WriteLine($"Liczba miejsc po usunięciu: {grupa.LiczbaMiejsc()}");
        Console.WriteLine($"Liczba osób po usunięciu: {grupa.LiczbaOsob()}");

        Console.WriteLine("\nUsunięcie osób o nazwisku 'Nowak':");
        grupa -= "Nowak";
        Console.WriteLine($"Liczba miejsc po usunięciu: {grupa.LiczbaMiejsc()}");
        Console.WriteLine($"Liczba osób po usunięciu: {grupa.LiczbaOsob()}");

        Grupa grupa2 = new Grupa();
        grupa2.DodajOsobe(osoba1);
        grupa2.DodajOsobe(osoba3);

        Console.WriteLine("\nPorównanie grup pod kątem liczby miejsc:");
        if (grupa > grupa2)
        {
            Console.WriteLine("Grupa ma więcej miejsc.");
        }
        else if (grupa < grupa2)
        {
            Console.WriteLine("Grupa ma mniej miejsc.");
        }
        else
        {
            Console.WriteLine("Grupy mają tę samą liczbę miejsc.");
        }

        Console.WriteLine("\nPorównanie grup pod kątem liczby osób:");
        if (grupa > 1)
        {
            Console.WriteLine("Grupa ma więcej osób.");
        }
        else if (grupa < 1)
        {
            Console.WriteLine("Grupa ma mniej osób.");
        }
        else
        {
            Console.WriteLine("Grupa ma tę samą liczbę osób.");
        }
    }
}