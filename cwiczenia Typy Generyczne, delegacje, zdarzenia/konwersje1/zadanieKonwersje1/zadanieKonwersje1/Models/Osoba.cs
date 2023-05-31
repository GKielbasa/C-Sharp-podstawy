using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieKonwersje1.Models
{
    internal class Osoba
    {
        public int id { get; set; }
        private static int nextID = 0;

        public string ImieINazwisko { get; set; }
        public string NrTelefonu { get; set; }

        public Osoba(string imieInazwisko)
        {
            this.ImieINazwisko = imieInazwisko;

            this.id = ++nextID;
        }

        public Osoba(string imieInazwisko, string nrTelefonu)
        {

            this.ImieINazwisko = imieInazwisko;
            this.NrTelefonu = nrTelefonu;
            if (this.GetType() == typeof(Osoba))
            {
                nextID++;
                this.id = nextID;
            }

        }

        public static Osoba StworzOsobe(string imieINazwisko, string nrTelefonu) // fabryka obiektów - metoda statyczna
        {
            return new Osoba(imieINazwisko, nrTelefonu);
        }

        public virtual void wypiszOsobe()
        {
            Console.WriteLine($"\tID: {this.id}\n\t Imię i nazwisko: {this.ImieINazwisko}\n\t nr telefonu:{this.NrTelefonu}");
        }
    }
}
