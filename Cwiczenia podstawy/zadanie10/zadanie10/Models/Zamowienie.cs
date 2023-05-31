using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie10.Models;

namespace zadanie10.Models
{
    internal class Zamowienie
    {
        public DateTime DataRealizacji { get; set; }
        public Osoba Klient { get; set; }
        private Sprzedaz[] pozycje;
        private const int maxLiczbaPozcyjiwZamowieniu = 20;
        private int liczbaPozycji = 0;

        public Zamowienie(DateTime dataRealizacji,Osoba klient)
        {
            this.DataRealizacji = dataRealizacji;
            this.Klient = klient;
            this.pozycje = new Sprzedaz[maxLiczbaPozcyjiwZamowieniu];
        }

        public void dodajPozycje(Sprzedaz pozycja)
        {
            if (liczbaPozycji < maxLiczbaPozcyjiwZamowieniu)
            {
                pozycje[liczbaPozycji] = pozycja;
                liczbaPozycji++;
            }
        }



        public void wypiszZamowienie()
        {
            Console.WriteLine($"Zamówienie klienta {Klient.ImieINazwisko}\ndata: {this.DataRealizacji}\n" +
                $"liczbna pozycji: {this.liczbaPozycji}\n");
            for (int i = 0; i < liczbaPozycji; i++)
            {
                var pozycja = pozycje[i];
                Console.Write($"{i + 1}. ");
                pozycja.wypiszInfoProduktu();
            }
        }
    }
}
