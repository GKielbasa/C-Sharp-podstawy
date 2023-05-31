using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7.Models
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
            foreach(Osoba osoba in listaUczestinikow)
            {
                if (osoba != null)
                {
                    Console.WriteLine(osoba.ImieINazwisko);
                }
            }
        }

        public void DodajCzlonkaGrupy(Osoba osoba)
        {
            if (liczbaOsobWGRP <maxOsobWGrp)
            {
                listaUczestinikow[liczbaOsobWGRP++] = osoba;
            }
            else
            {
                Console.WriteLine("grupa jest juz pełna !");
            }
        }
    }
}
