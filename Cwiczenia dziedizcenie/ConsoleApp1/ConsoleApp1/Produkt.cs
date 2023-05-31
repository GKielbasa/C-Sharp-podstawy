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
        public double cena { get; set; }
        public string jednostkaMiary { get; set; }
        public DateTime dataZakupu { get; set; }
        public double stawkaVAT { get; set; }
        public double marza { get; set; }

        public Produkt(string nazwa, double cena, string jednostkaMiary, DateTime dataZakupu,
            double stawkaVat, double marza)
        {
            this.nazwa = nazwa;
            this.cena = Math.Round(cena);
            this.jednostkaMiary = jednostkaMiary;
            this.dataZakupu = dataZakupu;
            this.stawkaVAT = Math.Round(stawkaVat);
            this.marza = Math.Round(marza);
        }

        public Produkt()
        {
            Console.WriteLine("Podaj nazwe produktu: ");
            this.nazwa = Console.ReadLine();

            Console.WriteLine("Podaj cene produktu: ");
            this.cena = Math.Round(double.Parse(Console.ReadLine()));

            Console.WriteLine("Podaj jednostke miary: ");
            this.jednostkaMiary = Console.ReadLine();

            //Console.WriteLine("Podaj date zakupu: ");
            //this.dataZakupu = DateTime.Parse(Console.ReadLine());
            this.dataZakupu = DateTime.Now;

            Console.WriteLine("Podaj stawkę vat: ");
            this.stawkaVAT = Math.Round(double.Parse(Console.ReadLine()));

            Console.WriteLine("Podaj marze: ");
            this.marza = Math.Round(double.Parse(Console.ReadLine()));

        }

        public void wypiszProduk()
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
