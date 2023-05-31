using System;
using System.Numerics;
using zadanie4.Models;

public class Program
{
    public static void Main(string[] args)
    {
       Produkt p1 = new Produkt("gruszka",5.00,"kg",new DateTime(2023,1,1), 0.50, 1.0);

        p1.wypiszProduk();

        Console.WriteLine();
        Produkt p2 = new Produkt();
        p2.wypiszProduk();

        Console.WriteLine();
        Produkt p3 = (Produkt)p1.Clone();
        p3.wypiszProduk();
    }
}