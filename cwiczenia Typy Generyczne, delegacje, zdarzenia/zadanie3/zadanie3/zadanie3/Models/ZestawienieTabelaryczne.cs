using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3.Models
{
    internal class ZestawienieTabelaryczne<T>
    {
        private T[] obiekty;

        public ZestawienieTabelaryczne(T[] obiekty)
        {
            this.obiekty = obiekty;
        }
        public void GenerateReport()
        {
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                
                Console.Write($"{property.Name.PadRight(20)}");
            }
            Console.WriteLine();

            foreach (T item in obiekty)
            {
                foreach (var property in properties)
                {
                    
                    Console.Write($"{property.GetValue(item).ToString().PadRight(20)}");
                }
                Console.WriteLine();
            }
        }
    }
}
