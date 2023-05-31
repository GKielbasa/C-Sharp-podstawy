using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1.Models
{
    internal class Osobowy : Samochod
    {
        public int LiczbaMiejsc { get; set; }
        public int PredkoscMax { get; set; }
        private static int licznikOsobowych = 0;
        
        public Osobowy(int liczbaMiejsc, int predkoscMax, string marka, double pojemnoscSilnika, int przebieg, string wlasciciel)
            : base(marka,pojemnoscSilnika,przebieg,wlasciciel)
        {

            this.LiczbaMiejsc = liczbaMiejsc;
            this.PredkoscMax = predkoscMax;
            licznikOsobowych++;
        }

        public void Wypisz()
        {
            base.Wypisz();
            Console.WriteLine($"Liczba miejsc: {LiczbaMiejsc}\nprędkość max: {PredkoscMax}");
        }

        public static int PobierzLiczbeOsobowych()
        {
            return licznikOsobowych;
        }

        public static int LiczbaSamochodowOsobowych
        {
            get { return licznikOsobowych; }
        }
    }
}
