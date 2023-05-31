using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2.Models
{
    internal class Figura
    {
        public string typFigury { get; set; }
        public string kolorObramowania { get; set; }
        public string kolorKrawedzi { get; set; }

        public Figura(string typFigury, string kolorObramowania, string kolorKrawedzi)
        {
            this.typFigury = typFigury;
            this.kolorObramowania = kolorObramowania;
            this.kolorKrawedzi = kolorKrawedzi;
        }

        public void Naglowek()
        {
            Console.WriteLine("Typ figury: {0}", typFigury);
            Console.WriteLine("Kolor obramowania: {0}", kolorObramowania);
            Console.WriteLine("Kolor krawędzi: {0}", kolorKrawedzi);
        }
        public virtual void Pole()
        {

            Console.WriteLine("Pole figury {0}",typFigury);
        }
        public virtual void Obwod()
        {

            Console.WriteLine($"obwod figury {typFigury}");
        }
    }
}
