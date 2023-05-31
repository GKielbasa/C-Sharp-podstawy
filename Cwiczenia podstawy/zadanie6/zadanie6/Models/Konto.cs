using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6.Models
{
    internal class Konto
    {
        public int NrKonta { get; set; }
        public string DaneWlasciciela { get; set; }
        public DateTime DataUtworzenia { get; set; }

        private const int maxLiczbaUzan = 500;
        private const int maxLiczbaObciazen = 1000;
        private Transakcja[][] transakcje;
        private int liczbaUznan = 0;
        private int liczbaObciazen = 0;

        public Konto(int numerKonta, string daneWlasciciela, DateTime dataUtworzenia)
        {
            this.NrKonta = numerKonta;
            this.DaneWlasciciela = daneWlasciciela;
            this.DataUtworzenia = dataUtworzenia;

            transakcje = new Transakcja[2][];
            transakcje[0] = new Transakcja[maxLiczbaUzan];
            transakcje[1] = new Transakcja[maxLiczbaObciazen];
        }

        public void wypiszInfoOKoncie()
        {
            Console.WriteLine($"Imię i nazwisko wlascicela: {this.DaneWlasciciela}\nNr konta: {this.NrKonta}" +
                $"\nData utworzenia: {this.DataUtworzenia}");

        }

        public override string ToString()
        {
            return $"Numer konta: {this.NrKonta}, Właściciel: {this.DaneWlasciciela}, data utworzenia: {this.DataUtworzenia}";
        }

        public void DidajTransakcje(Transakcja transakcja)
        {
            if (transakcja.kwota > 0 && liczbaUznan < maxLiczbaUzan)
            {
                transakcje[0][liczbaUznan] = transakcja;
                liczbaUznan++;
            }
            else if (transakcja.kwota < 0 && maxLiczbaObciazen < maxLiczbaObciazen)
            {
                transakcje[1][maxLiczbaObciazen] = transakcja;
                liczbaObciazen++;
            }
        }
    }
}
