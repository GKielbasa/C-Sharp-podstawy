using System;

using zadanie11.Models;

class Program
{
    static void Main(string[] args)
    {
       
        Osoba osoba1 = new Osoba(1, "Jan", "Kowalski", 70, 1.75);
        osoba1.wypiszOsobe();

        Console.WriteLine("BMI: " + osoba1.Bmi);

      
        Osoba osoba2 = new Osoba(2, "Anna", "Nowak", 55, 1.6);
        osoba2.wypiszOsobe();

        Console.WriteLine("BMI: " + osoba2.Bmi);

    }
}