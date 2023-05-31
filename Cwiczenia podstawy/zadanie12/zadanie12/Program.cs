using System;

namespace zadanie12.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Produkt produkt = new Produkt("Mleko", 2.5, "litr", DateTime.Now, 23, 10);
            Console.WriteLine("Produkt:");
            Console.WriteLine($"Nazwa: {produkt["nazwa"]}");
            Console.WriteLine($"Jednostka miary: {produkt["jednostkaMiary"]}");
            Console.WriteLine($"Cena: {produkt["cena"]}");
            Console.WriteLine($"Data zakupu: {produkt["dataZakupu"]}");
            Console.WriteLine($"Stawka VAT: {produkt["stawkaVAT"]}");
            Console.WriteLine($"Marża: {produkt["marza"]}");
            Console.WriteLine($"Cena detaliczna: {produkt.CenaDetaliczna}");

            Console.WriteLine();

            
            produkt["nazwa"] = "Chleb";
            produkt["cena"] = 3.0;

            Console.WriteLine("Po zmianie:");
            Console.WriteLine($"Nazwa: {produkt["nazwa"]}");
            Console.WriteLine($"Cena: {produkt["cena"]}");
            Console.WriteLine($"Cena detaliczna: {produkt.CenaDetaliczna}");

            
        }
    }
}
