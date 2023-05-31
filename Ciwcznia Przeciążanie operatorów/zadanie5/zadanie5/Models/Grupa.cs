using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie8;

namespace zadanie5.Models
{
    internal class Grupa
    {
        private List<Osoba> listaOsob;

        public Grupa()
        {
            listaOsob = new List<Osoba>();
        }

        public void DodajOsobe(Osoba osoba)
        {
            listaOsob.Add(osoba);
        }

        public void UsunOsobe(Osoba osoba)
        {
            listaOsob.Remove(osoba);
        }

        public void UsunOsobyONazwisku(string nazwisko)
        {
            listaOsob.RemoveAll(osoba => osoba.ImieINazwisko.Contains(nazwisko));
        }

        public int LiczbaMiejsc()
        {
            return listaOsob.Count;
        }

        public int LiczbaOsob()
        {
            return listaOsob.Count;
        }

        public static Grupa operator -(Grupa grupa, Osoba osoba)
        {
            grupa.UsunOsobe(osoba);
            return grupa;
        }

        public static Grupa operator -(Grupa grupa, string nazwisko)
        {
            grupa.UsunOsobyONazwisku(nazwisko);
            return grupa;
        }

        public static bool operator >(Grupa grupa1, Grupa grupa2)
        {
            return grupa1.LiczbaMiejsc() > grupa2.LiczbaMiejsc();
        }

        public static bool operator <(Grupa grupa1, Grupa grupa2)
        {
            return grupa1.LiczbaMiejsc() < grupa2.LiczbaMiejsc();
        }

        public static bool operator >(Grupa grupa, int liczba)
        {
            return grupa.LiczbaOsob() > liczba;
        }

        public static bool operator <(Grupa grupa, int liczba)
        {
            return grupa.LiczbaOsob() < liczba;
        }
    }
}
