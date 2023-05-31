using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wyjątki;

namespace zad8.Models
{
    internal class Wektor : IStatystyka
    {
        public int liczbaWspolrzednych { get; set; }
        public double[] wspolrzedne { get; set; }

        public Wektor(int n, double[] dane)
        {
            if (n<0)
            {
                throw new ArgumentException("Liczba wspolrzednych nie moze byc ujemna");
            }

            this.liczbaWspolrzednych = n;
            this.wspolrzedne = new double[n];
            for (int i = 0; i < dane.Length; i++)
            {
                if ( i>=n )
                {
                    throw new IndexOutOfRangeException("Próba zaisania wartości do elementu tablicy znajdującym się poza zakresem tablicy.");
                }
                this.wspolrzedne[i] = dane[i];
            }
        }

        public virtual void show()
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
            if ( v == null)
            {
                throw new ArgumentNullException("vektor nie moze byc null.");
            }
            if (this.liczbaWspolrzednych != v.liczbaWspolrzednych)
            {
                throw new InneWymiaryException("Wektory muszą mieć taki sam wymiar"); //przećwiczono tworzenie własnych wyjątków implementujących interface exceptions 
            }
            double[] noweWspolrzedne = new double[this.liczbaWspolrzednych];
            for (int i = 0; i < this.liczbaWspolrzednych; i++)
            {
                noweWspolrzedne[i] = this.wspolrzedne[i] + v.wspolrzedne[i];
            }
            return new Wektor(this.liczbaWspolrzednych, noweWspolrzedne);
        }

        public static Wektor operator +(Wektor v1, Wektor v2)
        {
            return v1.Add(v2);
        }


        public static Wektor operator *(Wektor v1, double liczba)
        {
            double[] noweWspolrzedne = new double[v1.liczbaWspolrzednych];
            for (int i = 0; i < v1.liczbaWspolrzednych; i++)
            {
                noweWspolrzedne[i] = v1.wspolrzedne[i] * liczba;
            }
            return new Wektor(v1.liczbaWspolrzednych, noweWspolrzedne);
        }

        public static double operator *(Wektor v1, Wektor v2)
        {
            if (v1.wspolrzedne != v2.wspolrzedne)
            {
                throw new ArgumentException("Wektory muszą mieć taki sam wymiar");
            }
            double iloczynSkalarny = 0;
            for (int i = 0; i < v1.liczbaWspolrzednych; i++)
            {
                iloczynSkalarny += v1.wspolrzedne[i] * v2.wspolrzedne[i];
            }
            return iloczynSkalarny;
        }


        //skorzystamy z metod wbudowanych w C# takich jak Sum(), Average(), Max()
        public double Suma()
        {
            return this.wspolrzedne.Sum();
        }
        public double Srednia()
        {
            return this.wspolrzedne.Average();
        }
        public double Max()
        {
            return this.wspolrzedne.Max();
        }
    }
}
