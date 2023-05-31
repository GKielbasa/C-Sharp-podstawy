using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1.Models
{
    internal class Ciezarowy : Samochod
    {
        public double ladownosc { get; set; }
        public double dopuszczalnaMasaPrzyczepy { get; set; }
        private static int liczbaCiezarowych = 0;

        public Ciezarowy(double ladownosc, double dopuszczalnaMasaPrzyczepy, string marka, double pojemnoscSilnika, int przebieg, string wlasciciel) 
            :base(marka, pojemnoscSilnika, przebieg, wlasciciel)
        {
            this.ladownosc = ladownosc;
            this.dopuszczalnaMasaPrzyczepy = dopuszczalnaMasaPrzyczepy;
            liczbaCiezarowych++;
        }

        public void Wypisz()
        {
            base.Wypisz();
            Console.WriteLine($"ladowność: {ladownosc}\ndopuszczalna masa przyczepy: {dopuszczalnaMasaPrzyczepy}");
        }

        //public static int PobierzLiczbeCiezarowych()
        //{
        //    return liczbaCiezarowych;
        //}

        public static int LiczbaSamochodowCiezarowych
        {
            get { return liczbaCiezarowych; }
        }
    }
}
