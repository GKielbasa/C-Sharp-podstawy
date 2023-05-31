using System;
using System.Security.Cryptography.X509Certificates;

namespace zadanie2.Models
{
    internal class Punkt
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punkt() { }
        public Punkt(double x, double y)
        {
            X = x;
            Y = y;
        }
        public void Wypisz()
        {
            Console.WriteLine($"współżędne punktu: \t x: {X} \t y: {Y}");
        }

        
    }
}
