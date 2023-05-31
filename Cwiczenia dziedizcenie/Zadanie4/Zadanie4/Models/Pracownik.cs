using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4.Models
{
    internal class Pracownik
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal[] salary { get; set; } //zakladamy ze bedzie przechowywac zestawienie roczne pensji

        private static int liczbaPracownikow = 0;
        private static decimal sumaPensji = 0; 
        public static decimal SredniaPensja
        {
            get
            {
                if (liczbaPracownikow == 0) { return 0; }

                return sumaPensji / liczbaPracownikow;
            }
        }
       
        public Pracownik(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.salary = new decimal[12];
            liczbaPracownikow++;
            
            
        }

        public void WypiszInfoPracownika()
        {
            Console.WriteLine($"Imię: {Name},\nNazwisko: {Surname}");
        }

        public static int iluPracownikow()
        {
            return liczbaPracownikow;
        }

        
    }
}
