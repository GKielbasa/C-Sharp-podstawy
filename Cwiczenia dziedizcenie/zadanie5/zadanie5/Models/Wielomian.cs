using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5.Models
{
    internal class Wielomian : Wektor
    {
        public Wielomian(int n, double[] dane ) : base(n, dane)
        { 

        }

        public double DajWartosc(double x)
        {
            double wartosc = 0;
            for (int i = 0; i < this.liczbaWspolrzednych; i++)
            {
                wartosc += this.wspolrzedne[i] * Math.Pow(x, i);
            }
            return wartosc;
        }

        public override void show()
        {
            base.show();
            StringBuilder wielomian = new StringBuilder();

            for (int i = this.liczbaWspolrzednych - 1; i >= 0; i--)
            {
                if (this.wspolrzedne[i] != 0)
                {
                    wielomian.Append(this.wspolrzedne[i] > 0 ? " + " : " - ");
                    wielomian.Append(Math.Abs(this.wspolrzedne[i]));
                    if (i > 0)
                    {
                        wielomian.Append("x");
                        if (i > 1)
                        {
                            wielomian.Append("^" + i);
                        }
                        
                    }
                }
            }
            if (wielomian.Length > 0 && wielomian[1] == '+')
            {
                wielomian.Remove(0, 3);
            }
            Console.WriteLine("Wielomian: "+ wielomian);
        }
    }
}
