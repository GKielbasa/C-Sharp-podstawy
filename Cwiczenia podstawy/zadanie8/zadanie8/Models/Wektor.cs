using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8.Models
{
    //niestety nasza grupa A nie mieliśmy żadnej kalsy czytacz aby zrobić pkt b.
    internal class Wektor
    {
        public  int liczbaWspolrzednych { get; set; }
        private double[] wspolrzedne;
        private static Random random;
        private static char typNawiasow;

        public Wektor(int n, double[] dane)
        {
            this.liczbaWspolrzednych = n;
            this.wspolrzedne = new double[n];
            for (int i = 0; i < dane.Length; i++)
            {
                this.wspolrzedne[i] = dane[i];
            }
        }

        public Wektor(double[] dane)
        {
            this.liczbaWspolrzednych = dane.Length;
            this.wspolrzedne = new double[liczbaWspolrzednych];

            for (int i = 0;i < dane.Length; i++)
            {
                this.wspolrzedne[i] = dane[i];
            }
        }

        static Wektor()
        {
            Console.WriteLine("Podaj typ nawiasów: ");
            typNawiasow = char.Parse(Console.ReadLine());
            random = new Random();
            
        }

        public Wektor (int n, double a, double b)
        {
            this.liczbaWspolrzednych = n;
            this.wspolrzedne = new double[liczbaWspolrzednych];
            for (int i = 0; i < n; i++)
            {
                this.wspolrzedne[i] =Math.Round(a + random.NextDouble() * (b - a));
            }
        }



        public void show()
        {
            foreach (double vektor in wspolrzedne)
            {
                Console.WriteLine($"wspolrzedne : {vektor}");
            }
            Console.WriteLine();
        }

        public double SumujWspolrzedne()
        {
            double suma = 0;
            foreach (double vektor in wspolrzedne)
            {
                suma += vektor;
            }
            return suma;
        }

        public Wektor Add(Wektor v)
        {
            if (this.liczbaWspolrzednych != v.liczbaWspolrzednych)
            {
                Console.WriteLine("Wektory musza miec taki sam wymair");
            }
            double[] noweWspolrzedne = new double[this.liczbaWspolrzednych];
            for (int i = 0; i < this.liczbaWspolrzednych; i++)
            {
                noweWspolrzedne[i] = this.wspolrzedne[i] + v.wspolrzedne[i];
            }
            return new Wektor(this.liczbaWspolrzednych, noweWspolrzedne);
        }
    }
}

