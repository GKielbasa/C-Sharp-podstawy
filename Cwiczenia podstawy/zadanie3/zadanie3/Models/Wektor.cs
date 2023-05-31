using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3.Models
{
    internal class Wektor
    {
        private int liczbaWspolrzednych;
        private double[] wspolrzedne;

        public Wektor(int n, double[] dane) 
        {
            this.liczbaWspolrzednych = n;
            this.wspolrzedne = new double[n];
            for (int i = 0; i < dane.Length; i++)
            {
                this.wspolrzedne[i] = dane[i];
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
            for (int i = 0; i< this.liczbaWspolrzednych; i++)
            {
                noweWspolrzedne[i] = this.wspolrzedne[i] + v.wspolrzedne[i];
            }
            return new Wektor(this.liczbaWspolrzednych, noweWspolrzedne);
        }
    }
}
