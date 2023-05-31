using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2.Models
{
    internal class Prostokat : Figura
    {
        public decimal bokA { get; set; }
        public decimal bokB { get; set; }
        public Prostokat(string typFigury, string kolorObramowania, string kolorKrawedzi,decimal bokA, decimal bokB) 
            : base(typFigury, kolorObramowania, kolorKrawedzi)
        {
            this.bokA = bokA;
            this.bokB = bokB;
        }
        public override void Pole()
        {
            base.Pole();
            decimal pole = bokA * bokB;
            Console.WriteLine($"wymiary:  A:{bokA}, B:{bokB} wynosi: {pole}");
        }

        public override void Obwod()
        {
            base.Obwod();
            decimal obwod = 2 * bokA + 2 * bokB;
            Console.WriteLine($"wymiary A:{bokA}, B:{bokB} wynosi: {obwod}");
        }
    }
}
