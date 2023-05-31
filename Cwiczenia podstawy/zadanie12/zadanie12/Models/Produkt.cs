using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zadanie12.Models
{
    internal class Produkt
    {
        public string nazwa { get; set; }
        public double cena { get; set; }
        public string jednostkaMiary { get; set; }
        public DateTime dataZakupu { get; set; }
        public double stawkaVAT { get; set; }
        public double marza { get; set; }

        public double CenaDetaliczna
        {
            get { return cena + cena * (marza / 100) + cena * (stawkaVAT / 100); }
        }

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

        public object this[string key]
        {
            get
            {
                switch (key)
                {
                    case "nazwa":
                        return nazwa;
                    case "jednostkaMiary":
                        return jednostkaMiary;
                    case "cena":
                        return cena;
                    case "dataZakupu":
                        return dataZakupu;
                    case "stawkaVAT":
                        return stawkaVAT;
                    case "marza":
                        return marza;
                    default:
                        throw new ArgumentException("Invalid key");
                }
            }
            set
            {
                switch (key)
                {
                    case "nazwa":
                        nazwa = (string)value;
                        break;
                    case "jednostkaMiary":
                        jednostkaMiary = (string)value;
                        break;
                    case "cena":
                        cena = (double)value;
                        break;
                    case "dataZakupu":
                        dataZakupu = (DateTime)value;
                        break;
                    case "stawkaVAT":
                        stawkaVAT = (double)value;
                        break;
                    case "marza":
                        marza = (double)value;
                        break;
                    default:
                        throw new ArgumentException("Invalid key");
                }
            }
        }

    }
}
