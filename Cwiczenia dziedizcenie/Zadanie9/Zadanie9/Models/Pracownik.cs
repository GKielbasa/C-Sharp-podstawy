using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie9.Models;

namespace Zadanie9.Models
{
    internal class Pracownik : Osoba
    {
        new string NrTelefonu { get; set; } // w taki sposób informujemy kompilator ze chcemy nadpisać pole z klasy bazowej
        private static int nextID = 0;



        public Pracownik(string imieInazwisko, string nrTelefonu) : base(imieInazwisko)
        {
            this.NrTelefonu = nrTelefonu;
            this.id = ++nextID;
        }
        public override void wypiszOsobe()
        {
            Console.WriteLine("pracownik: ");
            base.wypiszOsobe();
        }

        public new static Pracownik StworzOsobe(string imieINazwisko, string nrTelefonu)
        {
            return new Pracownik(imieINazwisko, nrTelefonu);
        }
    }
}
