using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6.Models
{
    internal class Produkt
    {
        public string nazwa { get; set; }
        public decimal cena { get; set; }
        public string jednostkaMiary { get; set; }
        public DateTime dataZakupu { get; set; }
        public decimal stawkaVAT { get; set; }
        public decimal marza { get; set; }

        public Produkt(string nazwa, decimal cena, string jednostkaMiary, DateTime dataZakupu,
            decimal stawkaVat, decimal marza)
        {
            this.nazwa = nazwa;
            this.cena = Math.Round(cena);
            this.jednostkaMiary = jednostkaMiary;
            this.dataZakupu = dataZakupu;
            this.stawkaVAT = Math.Round(stawkaVat)/100;
            this.marza = Math.Round(marza)/100;
        }

        public Produkt(Produkt produkt) // kosntr kopiujacy 
        {
            this.nazwa = produkt.nazwa;
            this.cena = produkt.cena;
            this.jednostkaMiary = produkt.jednostkaMiary;
            this.dataZakupu = produkt.dataZakupu;
            this.stawkaVAT = produkt.stawkaVAT;
            this.marza = produkt.marza;
        }

        public Produkt()
        {
            Console.WriteLine("Podaj nazwe produktu: ");
            this.nazwa = Console.ReadLine();

            Console.WriteLine("Podaj cene produktu: ");
            this.cena = Math.Round(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Podaj jednostke miary: ");
            this.jednostkaMiary = Console.ReadLine();

            //Console.WriteLine("Podaj date zakupu: ");
            //this.dataZakupu = DateTime.Parse(Console.ReadLine());
            this.dataZakupu = DateTime.Now;

            Console.WriteLine("Podaj stawkę vat: ");
            this.stawkaVAT = Math.Round(decimal.Parse(Console.ReadLine())/100);

            Console.WriteLine("Podaj marze: ");
            this.marza = Math.Round(decimal.Parse(Console.ReadLine()) / 100);

        }

        public virtual void wypiszProduk()
        {
            Console.WriteLine($"nazwa: {this.nazwa}\ncena: {this.cena}\njednostka miary: {this.jednostkaMiary}\n" +
                $"data zakupu: {this.dataZakupu}\nstawka vat: {this.stawkaVAT}\nmarza: {this.marza}");
        }

        public object Clone()
        {
            return this.MemberwiseClone(); // metoda tworzy klon obiektu 
        }
    }
}
