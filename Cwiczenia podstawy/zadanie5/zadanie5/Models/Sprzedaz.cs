using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5.Models
{
    internal class Sprzedaz
    {
        public string nazwaProduktu { get; set; }
        public int ilosc { get; set; }
        public decimal cena { get; set; }

        public Sprzedaz(string nazwa, int ilosc, decimal cena) 
        {
            this.nazwaProduktu = nazwa;
            this.ilosc = ilosc;
            this.cena = cena;
        }

        public void wypiszInfoProduktu()
        {
            Console.WriteLine($"{this.nazwaProduktu}\tcena: {this.cena} zł\tw ilosci: {this.ilosc}");

        }
    }
}
