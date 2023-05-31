using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_domowe_Dziedziczenie.Models
{
    internal class Pudelko
    {
        //1.a) Zdefiniuj wszystkie pola jako publiczne (zła praktyka!).
        //public double szerokosc;
        //public double wysokosc;
        //public double glebokosc;
        //public string kolor;

        //1.l) zmien modyfikatory na private 
        private double szerokosc;
        private double wysokosc;
        private double glebokosc;
        private string kolor;
        private static int liczbaPudelek;

        //1.c) Utwórz konstruktor który tworzy obiekt pudełka pobierając wszystkie potrzebne dane
        //    w postaci argumentów.

        public Pudelko() 
        {
            liczbaPudelek++;
        } 
        public Pudelko(double szerokosc, double wysokosc, double glebokosc, string kolor) 
        {
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
            this.glebokosc = glebokosc;
            this.kolor = kolor;
            liczbaPudelek++;
        }

        //1.i) konstruktor kopiujacy
        public Pudelko(Pudelko pudelko) 
        {
            this.szerokosc = pudelko.szerokosc;
            this.wysokosc = pudelko.wysokosc;
            this.glebokosc = pudelko.glebokosc;
            this.kolor = pudelko.kolor;
            liczbaPudelek++ ;
        }

        //1.m) Utwórz metody pozwalające na zmianę wartości pól pudełka spoza klasy (jakiego typu
        //dostęp powinny posiadać te metody?).  -- public 
        public void  setSzerokosc (double nowaSzerokosc)
        {
            this.szerokosc = nowaSzerokosc;
        }
        public void setWysokosc(double nowaWysokosc)
        {
            this.wysokosc = nowaWysokosc;
        }
        public void setGlebokosc(double nowaGlebokosc)
        {
            this.glebokosc = nowaGlebokosc;
        }

        //1.n)Utwórz metodę wyliczającą i zwracającą objętość pudełka
        public double obliczObjetosc()
        {
            double objetoscPudelka = this.szerokosc*this.wysokosc*this.glebokosc;
            return objetoscPudelka;
        }

        public int zwrocLiczbePudelek()
        {
            return liczbaPudelek;
        }


    }
}
