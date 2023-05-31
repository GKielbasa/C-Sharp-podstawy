using System;
using System.Numerics;
using zadanie6.Models;

public class Program
{
    public static void Main(string[] args)
    {
       ProduktSpozywczy ps1 = new ProduktSpozywczy("mleko",50M,"Litr",DateTime.Now, 23M,50M,new DateTime(2023,6,9),0.5F);

        Produkt p1 = new Produkt(ps1);
        Console.WriteLine("Sprawdzmy to ! Co sie stanie jezeli skopiuje klase pochodna do klasy nadrzednej ?:");
        p1.wypiszProduk();

        Console.WriteLine();
        ps1.wypiszProduk();
        Console.WriteLine();
        bool czyTak = ps1.doSporzycia();
        Console.WriteLine($"Jadalne w dniu dzisiejszym czyli {DateTime.Now.ToString("dd.MM.yyyy")}: {czyTak}");

        bool czyJadalnyWDniu = ps1.sprawdzCzyBedzieJadalnyDnia(new DateTime(2021, 2, 1));
        Console.WriteLine($"Jadalne w dniu wskazanym w metodzie: {czyJadalnyWDniu}");       // to tylko test czy dziala wiec niema potrzeby tego sesownie opakowywac

        Console.WriteLine("Na koniec test kopiowania produktu spozywczego");
        ProduktSpozywczy ps2 = new ProduktSpozywczy(ps1,new DateTime(2025,5,10),0.5F);
        Console.WriteLine();
        Console.WriteLine();
        ps2.wypiszProduk();




    }
}