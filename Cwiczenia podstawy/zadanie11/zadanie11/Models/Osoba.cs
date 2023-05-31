using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie11.Models
{
    internal class Osoba
    {
        private int id;
        private string imie;
        private string nazwisko;
        private double waga; 
        private double wzrost; 

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public string ImieINazwisko
        {
            get { return $"{imie} {nazwisko}"; }
        }

        public double Bmi
        {
            get
            {
                if (wzrost > 0)
                    return Math.Round(waga / (wzrost * wzrost));
                else
                    throw new Exception("Wzrost musi być większy od 0.");
            }
        }
        public Osoba(int id, string imie, string nazwisko, double waga, double wzrost)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.waga = waga;
            this.wzrost = wzrost;
        }

        public void wypiszOsobe()
        {
            Console.WriteLine($"ID: {this.Id}\n\t Imię i nazwisko: {this.ImieINazwisko}");
        }
    }
}

