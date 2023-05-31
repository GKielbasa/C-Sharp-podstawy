using System;

namespace zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie obiektu osoba1
            Osoba osoba1 = new Osoba(1, "Jan Kowalski");
            osoba1.PrzypiszAdres("Lwowska", "Nowy Sącz", 123);
            osoba1.wypiszOsobe();

            Console.WriteLine();

            // Tworzenie obiektu osoba2
            Osoba osoba2 = new Osoba(2, "Anna Nowak", "123456789");
            osoba2.PrzypiszAdres("Nowa Stara", "Kraków", 456);
            osoba2.wypiszOsobe();

            Console.ReadKey();
        }
    }
}