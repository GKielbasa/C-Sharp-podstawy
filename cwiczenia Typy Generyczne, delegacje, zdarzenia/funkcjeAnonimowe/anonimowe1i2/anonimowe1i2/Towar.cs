using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5.Models
{
    internal class Towar : IComparable<Towar>
    {

        public string Nazwa { get; set; }
        public decimal Cena { get; set; }

        public Towar(string nazwa, decimal cena)
        {
            Nazwa = nazwa;
            Cena = cena;
        }
        public override string ToString()
        {
            return $"{Nazwa}, Cena: {Cena} zł";
        }

        public int CompareTo(Towar other)
        {
            return Cena.CompareTo(other.Cena);
        }
    }
}
