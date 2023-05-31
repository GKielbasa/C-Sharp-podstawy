using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7.Models
{
    internal class Kurs
    {
        public string nazwaKursu { get; set; }
        public int liczbaGodzin { get; set; }  
        public Osoba osobaProwadzaca { get; set; }
        private Grupa[] grupy;
        private const int maxIloscGrup = 10;

        public Kurs(string nazwaKursu, int liczbaGodzin, Osoba osobaProwadzaca)
        {
            this.nazwaKursu = nazwaKursu;
            this.liczbaGodzin = liczbaGodzin;
            this.osobaProwadzaca = osobaProwadzaca;
            grupy = new Grupa[maxIloscGrup];
        }

        public void Wypisz()
        {
            Console.WriteLine($"Nazwa kursu: {this.nazwaKursu}\tliczba godzin: {this.liczbaGodzin}\t" +
                $"osoba prowadzaca: {this.osobaProwadzaca.ImieINazwisko}\nCzłonkowie kursu: \n");
            foreach(Grupa grupa in grupy)
            {
                grupa?.wypiszGrupe();
            }
        }

        public void DodajGrupe(Grupa grupa)
        {
            for (int i = 0; i<maxIloscGrup; i++)
            {
                if (grupy[i] == null)
                {
                    grupy[i] = grupa;
                    break;
                }
            }
        }
        
    }
}
