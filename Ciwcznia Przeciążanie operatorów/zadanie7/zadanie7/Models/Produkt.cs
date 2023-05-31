using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7.Models
{
    internal class Produkt
    {
        public string nazwa { get; set; }
        public decimal cena { get; set; }
        public string jednostkaMiary { get; set; }
        public DateTime dataZakupu { get; set; }
        public decimal stawkaVAT { get; set; }
        public decimal marza { get; set; }
        public Opakowanie opakownaie { get; set; }

        public Produkt(string nazwa, decimal cena, string jednostkaMiary, DateTime dataZakupu,
            decimal stawkaVat, decimal marza)
        {
            this.nazwa = nazwa;
            this.cena = Math.Round(cena);
            this.jednostkaMiary = jednostkaMiary;
            this.dataZakupu = dataZakupu;
            this.stawkaVAT = Math.Round(stawkaVat) / 100;
            this.marza = Math.Round(marza) / 100;
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
            this.stawkaVAT = Math.Round(decimal.Parse(Console.ReadLine()) / 100);

            Console.WriteLine("Podaj marze: ");
            this.marza = Math.Round(decimal.Parse(Console.ReadLine()) / 100);

        }

        public virtual void wypiszProduk()
        {
            Console.WriteLine($"nazwa: {this.nazwa}\ncena: {this.cena}\njednostka miary: {this.jednostkaMiary}\n" +
                $"data zakupu: {this.dataZakupu}\nstawka vat: {this.stawkaVAT}\nmarza: {this.marza}\nOpakownaie:\n\t{this.opakownaie.ToString()}" +
                $"\n\tObjętość: {this.opakownaie.Objetosc}");
        }

        public object Clone()
        {
            return this.MemberwiseClone(); // metoda tworzy klon obiektu 
        }

        internal struct Opakowanie
        {
            public double Wysokosc { get; set; }
            public double Szerokosc { get; set; }
            public double Glebokosc { get; set; }
            public Material Material { get; set; }

            public double Objetosc
            {
                get { return Wysokosc * Szerokosc * Glebokosc; }
            }

            public Opakowanie(double wysokosc, double szerokosc, double glebokosc, Material material)
            {
                this.Wysokosc = wysokosc;
                this.Szerokosc = szerokosc;
                this.Glebokosc = glebokosc;
                this.Material = material;
            }
            public override string ToString()
            {
                return $"Wymiary: {Wysokosc}x{Szerokosc}x{Glebokosc}, Materiał: {Material}";
            }
        }
        internal enum Material
        {
            Karton,
            Szklo,
            Plastik,
            Aluminium,
            Papier
        }
    }
}
