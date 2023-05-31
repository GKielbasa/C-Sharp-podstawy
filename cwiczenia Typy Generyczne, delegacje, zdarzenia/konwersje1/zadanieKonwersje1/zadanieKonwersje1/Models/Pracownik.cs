using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieKonwersje1.Models
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

        // konwersja jawna
        public static explicit operator Pracownik(Student student)
        {
            return new Pracownik(student.ImieINazwisko, student.NrTelefonu);
        }
        
        
    }
}
