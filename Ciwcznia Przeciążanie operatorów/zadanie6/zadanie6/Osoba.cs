using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6
{
    internal class Osoba
    {
        public int Id { get; set; }
        public string ImieINazwisko { get; set; }
        public string NrTelefonu { get; set; }
        public Adres adres { get; set; }
        public Osoba(int id, string imieInazwisko)
        {
            this.Id = id;
            this.ImieINazwisko = imieInazwisko;
        }
        public Osoba(int id, string imieInazwisko, string nrTelefonu)
        {
            this.Id = id;
            this.ImieINazwisko = imieInazwisko;
            this.NrTelefonu = nrTelefonu;
        }

        public void wypiszOsobe()
        {
            Console.WriteLine($"ID: {this.Id}\n\t Imię i nazwisko: {this.ImieINazwisko}\n\t nr telefonu:{this.NrTelefonu}");
            Console.WriteLine($"Adres:\n\tUlica: {this.adres.Ulica}\n\tMiasto: {this.adres.Miasto}\n\tNumer domu: {this.adres.NrDomu} ");
        }

        internal struct Adres
        {
            public string Ulica { get; set; }
            public string Miasto { get; set; }
            public int NrDomu { get; set; }

            public Adres(string ulica, string miasto, int nrDomu)
            {
                this.Ulica = ulica;
                this.Miasto = miasto;
                this.NrDomu = nrDomu;
            }
        }

        public void PrzypiszAdres(string ulica, string miasto, int nrDomu)
        {
            this.adres = new Adres(ulica, miasto, nrDomu);
        }
    }
}
