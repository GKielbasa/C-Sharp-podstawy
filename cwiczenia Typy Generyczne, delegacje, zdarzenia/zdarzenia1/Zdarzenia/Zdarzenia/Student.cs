using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    public class Student : Osoba
    {
        public override string ReakcjaNaZwolanieSpotkania()
        {
            return Plec == "Kobieta" ? "Chętnie bym przyszła ale nie mogę bo idę na imprezę." : "Chętnie bym przyszedł ale nie mogę bo idę na imprezę.";
        }
    }
}
