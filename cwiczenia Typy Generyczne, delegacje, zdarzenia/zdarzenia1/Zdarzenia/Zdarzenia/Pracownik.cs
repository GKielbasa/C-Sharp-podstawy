using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    internal class Pracownik : Osoba
    {
        public override string ReakcjaNaZwolanieSpotkania()
        {
            return Plec == "Kobieta" ? "Chętnie bym przyszła ale nie mogę bo pracuję." : "Chętnie bym przyszedł ale nie mogę bo pracuję.";
        }
    }
}
