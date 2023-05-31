using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using zadanie3.Models;

namespace zadanie2.Models
{
    internal class Trojkat : Figura
    {
        public int bokA { get; set; }
        public int bokB { get; set; }
        public int bokC { get; set; }

        public Trojkat(string typFigury, string kolorObramowania, string kolorKrawedzi, int bokA, int bokB, int bokC)
            : base(typFigury, kolorObramowania, kolorKrawedzi)
        {
            this.bokA = bokA;
            this.bokB = bokB;
            this.bokC = bokC;
        }

        public override void Pole()
        {
            Console.WriteLine("Pole figury {0}", typFigury);
            double polObwod = (bokA + bokB + bokC) / 2;
            double pole = Math.Sqrt(polObwod * (polObwod - bokA) * (polObwod - bokB) * (polObwod - bokC));
            Console.WriteLine($"wymiary:  A:{bokA}, B:{bokB}, C:{bokC} wynosi: {pole}");
        }

        public override void Obwod()
        {
            Console.WriteLine("Obwod figury {0}", typFigury);
            double obwod = bokA + bokB + bokC;
            Console.WriteLine($"wymiary A:{bokA}, B:{bokB}, C:{bokC} wynosi: {obwod}");
        }

    }
}
