using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    public struct LWymierna
    {
        private int licznik;
        private int mianownik;

        public LWymierna(int licznik, int mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
        }

        public LWymierna (int licznik)
        {
            this.licznik = licznik;
            this.mianownik = 1;
        }
        public LWymierna()
        {
            this.licznik = 0;
            this.mianownik = 1;
        }

        public void wypiszUlamek()
        {
            if (this.licznik == 0)
            {
                Console.WriteLine(0);
            }
            else if (this.mianownik == 1) 
            { 
                Console.WriteLine(this.licznik); 
            }
            else
            {
                Console.WriteLine($"{this.licznik}/{this.mianownik}");
            }
               
        }
        public void WczytajUlamek(int licznik, int mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
        }
        private int  najwiekszyWspolnyDzielnik(int a, int b)
        {
            int tmp;
            while ( b!=0 )
            {
                tmp = b;
                Console.WriteLine($"tmp = {tmp}");
                b = a % b;
                a = tmp;
            }
            return a;
        }
        private int najmniejszaWspolnaWielokrotonosc(int a, int b)
        {
            return Math.Abs(a * b) / najwiekszyWspolnyDzielnik(a, b);
        }
        private LWymierna Dodaj(LWymierna b)
        {
            if (this.mianownik == b.mianownik)
            {
                return new LWymierna(this.licznik + b.licznik, this.mianownik);
            }
            else // trzeba sprowadzic ulamki do wpolnego mianownika 
            {
                int NWW = najmniejszaWspolnaWielokrotonosc(this.mianownik, b.mianownik);
                int nowyLicznik = this.licznik * (NWW / this.mianownik) + b.licznik * (NWW / b.mianownik);
                return new LWymierna(nowyLicznik, NWW);
            }
        }

        private LWymierna Odejmij(LWymierna b)
        {
            if (this.mianownik == b.mianownik)
            {
                return new LWymierna(this.licznik - b.licznik, this.mianownik);
            }
            else
            {
                int NWW = najmniejszaWspolnaWielokrotonosc(this.mianownik, b.mianownik);
                int nowyLicznik = this.licznik * (NWW / this.mianownik) - b.licznik * (NWW / b.mianownik);
                return new LWymierna(nowyLicznik , NWW);
            }
        }

        private LWymierna Razy(LWymierna b)
        {
            int nowyLicznik = this.licznik * b.licznik;
            int nowyMianownik = this.mianownik * b.mianownik;
            return new LWymierna(nowyLicznik, nowyMianownik);
        }

        private LWymierna Dziel(LWymierna b)
        {
            if (b.licznik == 0)
            {
                throw new DivideByZeroException("Niemożna dizelić przez 0 !");
                
            }
            int nowyLicznik = this.licznik * b.mianownik;
            int nowyMianownik = this.mianownik*b.licznik;
            return new LWymierna(nowyLicznik,nowyMianownik);
        }

        private bool Mniejsze(LWymierna b)
        {
            return (double)this.licznik / this.mianownik < (double)b.licznik / b.mianownik;
        }
        private LWymierna Minus()
        {
            return new LWymierna(-this.licznik, this.mianownik);
        }

        public static LWymierna operator +(LWymierna a, LWymierna b)
        {
            return a.Dodaj(b);
        }
        public static LWymierna operator -(LWymierna a,LWymierna b)
        {
            return a.Odejmij(b);
        }
        public static LWymierna operator *(LWymierna a, LWymierna b)
        {
            return a.Razy(b);
        }
        public static LWymierna operator /(LWymierna a, LWymierna b)
        {
            return a.Dziel(b);
        }
        public static LWymierna operator *(LWymierna a, int b)
        {
            return a.Razy(new LWymierna(b));
        }

        // musza zostac przeciazone obydwa < i > ianczej kompilator bedzie wskazywal błąd
        public static bool operator >(LWymierna a, LWymierna b)
        {
            double wartoscLogicznaA = (double)a.licznik / a.mianownik;
            double wartoscLogicznaB = (double)b.licznik /b.mianownik;

            return wartoscLogicznaA > wartoscLogicznaB;
        }
        public static bool operator <(LWymierna a, LWymierna b)
        {
            double wartoscLogicznaA = (double)a.licznik / a.mianownik;
            double wartoscLogicznaB = (double)b.licznik / b.mianownik;

            return wartoscLogicznaA < wartoscLogicznaB;
        }
        public static LWymierna operator -(LWymierna a)
        {
            return a.Minus();
        }
    }
}
