using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2.Models
{
    internal class Odcinek
    {
        private Punkt Poczatek { get; set; }
        private Punkt Koniec { get; set; }

        public Odcinek(Punkt a, Punkt b)
        {
            this.Poczatek = a;
            this.Koniec = b;
        }

        public void wypiszOdcinek()
        {
            Console.WriteLine($"odcinek o wspólrzędnych: A: {Poczatek.X},{Poczatek.Y} -> B:{Koniec.X},{Koniec.Y} ");
        }

        public double Dlugosc()
        {
            double dx = Koniec.X - Poczatek.X;
            double dy = Koniec.Y - Poczatek.Y;

            return Math.Round(Math.Sqrt(dx * dx + dy * dy));
        }

        public void UstawNowyPunktPoczatkowy(Punkt punkt)
        {
            Poczatek = punkt;
        }

        public void UstawNowyPunktKoncowy(Punkt punkt)
        {
            Koniec = punkt;
        }
        
    }
  
}
