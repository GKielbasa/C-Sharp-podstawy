using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1.Models
{
    internal class LiczbaZespolona
    {
        public double re { get; set; }
        public double im { get; set; }

        public LiczbaZespolona(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        // Skorzystam z metod statycznych aby nie musiec  tworzyc obiektu klasy LiczbaZespolona tylko operwać na typie LiczbaZespolona 
        public static LiczbaZespolona Dodaj(LiczbaZespolona lz1, LiczbaZespolona lz2)
        {
            return new LiczbaZespolona(lz1.re+ lz2.re, lz1.im + lz2.im);
        }

        public static LiczbaZespolona Odejmij(LiczbaZespolona lz1, LiczbaZespolona lz2)
        {
            return new LiczbaZespolona(lz1.re - lz2.re, lz1.im - lz2.im);
        }

        public static LiczbaZespolona Pomnoz(LiczbaZespolona lz1, LiczbaZespolona lz2)
        {
            return new LiczbaZespolona(lz1.re * lz2.re - lz1.im * lz2.im, lz1.re * lz2.im + lz1.im * lz2.re);
        }

        public static LiczbaZespolona Podziel(LiczbaZespolona lz1, LiczbaZespolona lz2 )
        {
            var denominator = lz2.re * lz2.re + lz2.im * lz2.im;
            var newRe = (lz1.re * lz2.re + lz1.im * lz2.im) / denominator;
            var newIm = (lz1.im * lz2.re - lz1.re * lz2.im) / denominator;
            return new LiczbaZespolona (newRe, newIm); 
        }

        // Przeciążenia 

        public static LiczbaZespolona operator +(LiczbaZespolona lz1, LiczbaZespolona lz2)
        {
            return Dodaj(lz1,lz2);
        }
        public static LiczbaZespolona operator -(LiczbaZespolona lz1, LiczbaZespolona lz2)
        {
            return Odejmij(lz1,lz2);
        }
        public static LiczbaZespolona operator *(LiczbaZespolona lz1, LiczbaZespolona lz2)
        {
            return Pomnoz(lz1, lz2);
        }
        public static LiczbaZespolona operator /(LiczbaZespolona lz1, LiczbaZespolona lz2)
        {
            return Podziel(lz1, lz2);
        }

        public static LiczbaZespolona operator -(LiczbaZespolona lz)
        {
            return new LiczbaZespolona(-lz.re, -lz.im);
        }

    }
}
