using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7.Models
{
    internal class Osoba
    {
        public int Id { get; set; }
        public string ImieINazwisko { get; set; }
        
        public Osoba(int id, string imieInazwisko)
        {
            this.Id = id;
            this.ImieINazwisko = imieInazwisko;
        }

        public void wypiszOsobe()
        {
            Console.WriteLine($"ID: {this.Id}\n\t Imię i nazwisko: {this.ImieINazwisko}");
        }
    }
}
