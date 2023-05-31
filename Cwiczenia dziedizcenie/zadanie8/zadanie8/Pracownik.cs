using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8
{
    internal class Pracownik : Osoba
    {
       new string NrTelefonu { get; set; } // w taki sposób informujemy kompilator ze chcemy nadpisać pole z klasy bazowej

        public Pracownik(int id, string imieInazwisko, string nrTelefonu) : base(id, imieInazwisko)
        {
            this.NrTelefonu = nrTelefonu;
        }
    }
}
