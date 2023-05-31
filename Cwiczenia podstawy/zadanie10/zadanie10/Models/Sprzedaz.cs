using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace zadanie10.Models
{
    internal class Sprzedaz
    {
        public Produkt Produkt { get; set; }
        public int ilosc { get; set; }
        public decimal cena { get; set; }

        public Sprzedaz(Produkt produkt, int ilosc, decimal cena)
        {
            this.Produkt = produkt;
            this.ilosc = ilosc;
            this.cena = cena;
        }

        public void wypiszInfoProduktu()
        {
            Console.WriteLine($"{this.Produkt.nazwa}\tcena: {this.cena} zł\tw ilosci: {this.ilosc}");
            
        }
    }
}
