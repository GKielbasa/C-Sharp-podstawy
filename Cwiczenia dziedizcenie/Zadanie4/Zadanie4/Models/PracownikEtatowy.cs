using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4.Models
{
    internal class PracownikEtatowy : Pracownik
    {
        public decimal PensjaBrutto { get;private  set; }
        public decimal SkladkaEmerytalna { get; private set; }
        public decimal SkladkaChrobowa { get; private set; }
        public decimal SkladkaRentowa { get; private set; }
        public decimal Podatek { get; private set; }
        

        public PracownikEtatowy(string name, string surname, decimal pensjaBrutto) 
            :base(name,surname)
        {
            this.PensjaBrutto = pensjaBrutto;
            this.Podatek = 0.18M *pensjaBrutto;
            this.SkladkaRentowa = 0.05M * pensjaBrutto;
            this.SkladkaChrobowa = 0.05M * pensjaBrutto;
            this.SkladkaEmerytalna = 0.10M * pensjaBrutto;
        }

        public decimal PensjaNetto ()
        {
            
            return PensjaBrutto - (SkladkaEmerytalna + SkladkaRentowa + SkladkaChrobowa + Podatek);
        }
        public void WypiszInfoPracownika()
        {
            base.WypiszInfoPracownika();
            Console.WriteLine($"Pensja Brutto: {PensjaBrutto},\nPensja Netto: {PensjaNetto()}");
        }

     
        
    }
}
