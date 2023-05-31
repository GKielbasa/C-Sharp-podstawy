using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie3.Models;

namespace zadanie3.Models
{
    internal class Prostokat : Figura
    {
        public decimal bokA { get; set; }
        public decimal bokB { get; set; }
        public Prostokat(string typFigury, string kolorObramowania, string kolorKrawedzi, decimal bokA, decimal bokB)
            : base(typFigury, kolorObramowania, kolorKrawedzi)
        {
            this.bokA = bokA;
            this.bokB = bokB;
        }
        public override void Pole()
        {
            Console.WriteLine("Pole figury {0}", typFigury);
            decimal pole = bokA * bokB;
            Console.WriteLine($"wymiary:  A:{bokA}, B:{bokB} wynosi: {pole}");
        }

        public override void Obwod()
        {
            Console.WriteLine("obowd figury {0}", typFigury);
            decimal obwod = 2 * bokA + 2 * bokB;
            Console.WriteLine($"wymiary A:{bokA}, B:{bokB} wynosi: {obwod}");
        }
    }
}
