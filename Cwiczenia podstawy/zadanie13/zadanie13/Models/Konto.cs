using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie13.Models
{
    internal class Konto
    {
        public int NrKonta { get; set; }
        public Osoba WlascicielKonta { get; set; }
        public DateTime DataUtworzenia { get; set; }

        private const int maxLiczbaUzan = 500;
        private const int maxLiczbaObciazen = 1000;
        private Transakcja[][] transakcje;
        private int liczbaUznan = 0;
        private int liczbaObciazen = 0;

        public decimal Saldo
        {
            get
            {
                decimal saldo = 0;
                for (int i = 0; i< liczbaUznan; i++)
                {
                    saldo += transakcje[0][i].kwota;
                }
                for (int i = 0; i<liczbaObciazen; i++)
                {
                    saldo -= transakcje[1][i].kwota;
                }
                return saldo;
            }
        }


        public Konto(int numerKonta, Osoba wlascicielKonta, DateTime dataUtworzenia)
        {
            this.NrKonta = numerKonta;
            this.WlascicielKonta = wlascicielKonta;
            this.DataUtworzenia = dataUtworzenia;

            transakcje = new Transakcja[2][];
            transakcje[0] = new Transakcja[maxLiczbaUzan];
            transakcje[1] = new Transakcja[maxLiczbaObciazen];
        }

        public void wypiszInfoOKoncie()
        {
            Console.WriteLine($"Imię i nazwisko wlascicela: {this.WlascicielKonta.ImieINazwisko}\nNr konta: {this.NrKonta}" +
                $"\nData utworzenia: {this.DataUtworzenia}");
            Console.WriteLine("Uznania: ");
            for(int i = 0; i<liczbaUznan; i++)
            {
                Console.WriteLine(transakcje[0][i]);
            }
            Console.WriteLine("Obciążenia: ");
            for (int i = 0;i<liczbaObciazen; i++)
            {
                Console.WriteLine(transakcje[1][i]);
            }
        }

        public override string ToString()
        {
            return $"Numer konta: {this.NrKonta}, Właściciel: {this.WlascicielKonta.ImieINazwisko}, data utworzenia: {this.DataUtworzenia}";
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

        // Indeksator 
        public Transakcja[] this[string typ]
        {
            get
            {
                if (typ == "uznania")
                    return transakcje[0];
                else if (typ == "obciazenia")
                    return transakcje[1];
                else
                    throw new ArgumentException("podales błędny typ");
            }
        }

        public void uznajKonto(Transakcja t)
        {
            if(liczbaUznan < maxLiczbaUzan)
            {
                transakcje[0][liczbaUznan] =t;
                liczbaUznan++;
            }
            else
            {
                throw new Exception("Maxymalna liczba uznań");
            }
        }

        public void obciazKonto (Transakcja t)
        {
            if (liczbaObciazen < maxLiczbaObciazen)
            {
                transakcje[1][liczbaObciazen] =t;
                liczbaObciazen++;
            }
            else
            {
                throw new Exception("Maxymalna liczba obciążeń");
            }
        }
    }
}
