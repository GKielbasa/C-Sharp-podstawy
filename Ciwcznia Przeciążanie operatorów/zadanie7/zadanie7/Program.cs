using System;
using static zadanie7.Models.Produkt;
using zadanie7.Models;

namespace zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            Produkt produkt1 = new Produkt("Produkt 1", 50, "szt.", DateTime.Now, 23, 10);
            produkt1.opakownaie = new Produkt.Opakowanie(10, 20, 5, Produkt.Material.Karton);
            produkt1.wypiszProduk();

            Console.WriteLine();

        }
    }
}