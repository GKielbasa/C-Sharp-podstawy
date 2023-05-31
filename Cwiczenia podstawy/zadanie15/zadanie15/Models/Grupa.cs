using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie15.Models
{
    internal class Grupa
    {
        private const int maxOsobWGrp = 10;
        private int liczbaOsobWGRP = 0;
        private Osoba[] listaUczestinikow;

        public Grupa()
        {
            listaUczestinikow = new Osoba[maxOsobWGrp];
        }

        public void wypiszGrupe()
        {
            foreach (Osoba osoba in listaUczestinikow)
            {
                if (osoba != null)
                {
                    Console.WriteLine(osoba.ImieINazwisko);
                }
            }
        }

        public void DodajCzlonkaGrupy(Osoba osoba)
        {
            if (liczbaOsobWGRP < maxOsobWGrp)
            {
                listaUczestinikow[liczbaOsobWGRP++] = osoba;
            }
            else
            {
                Console.WriteLine("grupa jest juz pełna !");
            }
        }
        public string this[int i, int wlasnosc]
        {
            get
            {
                if (i >= 0 && i < liczbaOsobWGRP)
                {
                    switch (wlasnosc)
                    {
                        case 1:
                            return listaUczestinikow[i].ImieINazwisko;
                        case 2:
                            return listaUczestinikow[i].Id.ToString();
                        default:
                            throw new IndexOutOfRangeException("index out of band!");
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
            }
        }

        public string this[int i, string property]
        {
            get
            {
                if (i >= 0 && i < liczbaOsobWGRP)
                {
                    switch (property)
                    {
                        case "ImieINazwisko":
                            return listaUczestinikow[i].ImieINazwisko; 
                        case "Id":
                            return listaUczestinikow[i].Id.ToString(); 
                        default:
                            throw new IndexOutOfRangeException("Property index is out of range");
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
            }
        }
    }
}
