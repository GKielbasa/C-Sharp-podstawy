using System;
using zadanie15.Models;

namespace zadanie15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Osoba osoba1 = new Osoba(1, "Jan Kowalski");
            Osoba osoba2 = new Osoba(2, "Anna Nowak");

            
            Grupa grupa = new Grupa();

           
            grupa.DodajCzlonkaGrupy(osoba1);
            grupa.DodajCzlonkaGrupy(osoba2);

            
            grupa.wypiszGrupe();

            // Testowanie indeksatorów
            try
            {
                Console.WriteLine("Imie i nazwisko pierwszej osoby (indeksator int): " + grupa[0, 1]);
                Console.WriteLine("ID drugiej osoby (indeksator int): " + grupa[1, 2]);
                Console.WriteLine("Imie i nazwisko pierwszej osoby (indeksator string): " + grupa[0, "ImieINazwisko"]);
                Console.WriteLine("ID drugiej osoby (indeksator string): " + grupa[1, "Id"]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}