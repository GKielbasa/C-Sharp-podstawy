using System;
using Zadanie4.Models;
class Program
{
    static void Main(string[] args)
    {
      PracownikEtatowy pe1 = new PracownikEtatowy("Jan", "Kowalski", 4000);
        pe1.WypiszInfoPracownika();

        Console.WriteLine();
        PracownikGodzinowy pg1 = new PracownikGodzinowy("Jan", "Kowalski", 20, 1000);
        pg1.WypiszInfoPracownika();

    }
}