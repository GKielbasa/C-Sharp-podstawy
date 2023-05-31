using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5.Models
{
    internal class Osoba : IComparable<Osoba>
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Plec { get; set; }

        public Osoba(string imie, string nazwisko, string plec)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Plec = plec;
        }
        public override string ToString()
        {
            string panCzyPani = (Plec == "K") ? "Pani" : "Pan";

            return $"{panCzyPani} {Imie} {Nazwisko}";
        }
        public int CompareTo(Osoba osoba)
        {
            if (osoba == null) return 1;
            int wynik = Nazwisko.CompareTo(osoba.Nazwisko);
            if (wynik == 0)
            {
                wynik = Imie.CompareTo(osoba.Imie);
            }
            return wynik;
        }
    }
}
