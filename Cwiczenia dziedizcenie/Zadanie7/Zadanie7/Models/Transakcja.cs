using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7.Models
{
    internal class Transakcja
    {
        public DateTime DataRealizacji { get; set; }
        public string Tytulem { get; set; }
        public decimal kwota { get; set; }

        public Transakcja(DateTime dataRealizacji, string tytulem, decimal kwota)
        {
            this.DataRealizacji = dataRealizacji;
            this.Tytulem = tytulem;
            this.kwota = kwota;
        }

        public void WypiszInfoTransakcji()
        {
            Console.WriteLine($"Data realizacji: {DataRealizacji}, Tytuł: {Tytulem}, kwota: {kwota}");
        }
    }
}
