using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8
{
    internal class Osoba
    {
        public int Id { get; set; }
        public string ImieINazwisko { get; set; }
        public string NrTelefonu { get; set; }
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
        }
    }
}
