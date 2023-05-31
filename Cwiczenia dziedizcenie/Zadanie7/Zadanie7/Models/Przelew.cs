using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7.Models
{
    internal class Przelew : Transakcja
    {
        public Konto KontoDocelowe { get; set; } // na ktore z ktorego przelano pieniadze
        public Konto KontoZrodlowe { get; set; }

        public Przelew(DateTime dataRealizacji, string tytulem, decimal kwota, Konto kontoDocelowe, Konto kontoZrodlowe) : base(dataRealizacji, tytulem, kwota)
        {
            this.KontoDocelowe = kontoDocelowe;
            this.KontoZrodlowe = kontoZrodlowe;
        }

        public void WypiszInfoTransakcji()
        {
            Console.WriteLine($"przelew z konta: {KontoZrodlowe.ToString()} do: {KontoDocelowe.ToString()}");
            base.WypiszInfoTransakcji();
            
        }
    }
}
