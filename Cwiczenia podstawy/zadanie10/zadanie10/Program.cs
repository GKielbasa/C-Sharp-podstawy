using System.Text.RegularExpressions;
using zadanie10.Models;

public class Program
{
    public static void Main(string[] args)
    {
        
        Produkt chleb = new Produkt("Chleb", 3.50, "sztuka", DateTime.Now, 0.08, 0.1);
        Produkt maslo = new Produkt("Masło", 5.00, "sztuka", DateTime.Now, 0.08, 0.15);
        Produkt mleko = new Produkt("Mleko", 2.20, "litr", DateTime.Now, 0.08, 0.12);

        
        Sprzedaz sprzedazChleb = new Sprzedaz(chleb, 1, (decimal)chleb.cena);
        Sprzedaz sprzedazMaslo = new Sprzedaz(maslo, 2, (decimal)maslo.cena);
        Sprzedaz sprzedazMleko = new Sprzedaz(mleko, 3, (decimal)mleko.cena);

        
        Osoba klient = new Osoba(1, "Jan Kowalski");

       
        Zamowienie zamowienie = new Zamowienie(DateTime.Now, klient);

       
        zamowienie.dodajPozycje(sprzedazChleb);
        zamowienie.dodajPozycje(sprzedazMaslo);
        zamowienie.dodajPozycje(sprzedazMleko);

        
        zamowienie.wypiszZamowienie();

       
      
    }
}
  