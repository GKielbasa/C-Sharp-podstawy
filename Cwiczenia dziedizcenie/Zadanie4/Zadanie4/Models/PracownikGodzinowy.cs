using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4.Models
{
    internal class PracownikGodzinowy : Pracownik
    {
        public decimal StawkaGodzinowa { get; private set; }
        public double LiczbaGodzin { get; private set; }

        public PracownikGodzinowy(string name, string surname, decimal stawkaGodzinowa, double liczbaGodzin)
            : base(name, surname)
        {
            this.StawkaGodzinowa = stawkaGodzinowa;
            this.LiczbaGodzin = liczbaGodzin;
        }

        public decimal zarobekRoczny ()
        {
            decimal zarobekRoczny = new decimal(this.LiczbaGodzin) * this.StawkaGodzinowa;
            return zarobekRoczny;
        }

        public  void WypiszInfoPracownika()
        {
            base.WypiszInfoPracownika();
            Console.WriteLine($"Liczba przepracowanych w ciągu roku godzin: {this.LiczbaGodzin}\nStawka godzinowa: {this.StawkaGodzinowa}\nZarobił: {zarobekRoczny()}");
        }
    }
}
