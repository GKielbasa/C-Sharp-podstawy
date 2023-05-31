using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6.Models
{
    internal class ProduktSpozywczy : Produkt
    {
        public DateTime dataWaznosci { get; set; }
        public float waga { get; set; }

        public ProduktSpozywczy(string nazwa, decimal cena, string jednostkaMiary, DateTime dataZakupu,
                       decimal stawkaVat, decimal marza, DateTime dataWaznosci, float waga) : base(nazwa, cena, jednostkaMiary, dataZakupu, stawkaVat, marza)
        {
            this.dataWaznosci = dataWaznosci;
            this.waga = waga;
        }

        public ProduktSpozywczy(Produkt produkt, DateTime dataWaznosci, float waga)
            : base(produkt)
        {
            this.dataWaznosci = dataWaznosci;
            this.waga = waga;
        }

        public bool doSporzycia()
        {
            bool doSporzycia = false;
            if (this.dataWaznosci >= DateTime.Now) 
            {
                doSporzycia = true;
            }
            
            return doSporzycia;
        }
        public bool sprawdzCzyBedzieJadalnyDnia(DateTime dataDoSprawdzenia)
        {
            bool czyJadalne = false;
            if (this.dataWaznosci <= dataDoSprawdzenia)
            {
                czyJadalne = true;
            }

                return czyJadalne;
        }

        public override void wypiszProduk()
        {
            base.wypiszProduk();
            Console.WriteLine($"Data ważności: {this.dataWaznosci.ToString("dd.MM.yyyy")}");
        }
    }
}
