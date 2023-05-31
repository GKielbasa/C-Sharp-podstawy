using System;
using zadanie5.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Sprzedaz s1 = new Sprzedaz("Jabłko",2,5);
        Sprzedaz s2 = new Sprzedaz("Gruszka",3,7);
        s1.wypiszInfoProduktu();

        Zamowienie z1 = new Zamowienie(DateTime.Now, "Żabka"); 
        z1.dodajPozycje(s1 );
        z1.dodajPozycje(s2 );
        z1.wypiszZamowienie();
    }
}