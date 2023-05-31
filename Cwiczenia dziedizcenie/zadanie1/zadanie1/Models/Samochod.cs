using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1.Models
{
    internal class Samochod
    {
        public string marka { get; set; }
        public double pojemnoscSilnika { get; set; }
        public int przebieg { get; set; }
        public string wlasciciel { get; set; }

        private static int licznikSamochodow = 0;

       

        
        public Samochod(string marka, double pojemnoscSilnika, int przebieg, string wlasciciel)
        {
            this.marka = marka;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.przebieg = przebieg;
            this.wlasciciel = wlasciciel;
            licznikSamochodow++;
        }

        public void Wypisz()
        {
            Console.WriteLine($"Marka: {marka}\nPojemność silnika: {pojemnoscSilnika}\nPrzebieg: {przebieg}\n Właściciel: {wlasciciel}");
        }

        //public static int PobierzLiczbeSamochodow()
        //{
        //    return licznikSamochodow;
        //}

        public static int LiczbaSamochodowOgolnie
        {
            get { return licznikSamochodow; }
        }


    }
}
