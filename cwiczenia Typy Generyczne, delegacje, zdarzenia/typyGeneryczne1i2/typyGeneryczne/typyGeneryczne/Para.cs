using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typyGeneryczne
{
    internal class Para<T> where T : class
    {
        public T First { get; set; }
        public T Second { get; set; }

        public Para(T first, T second)
        {
            First = first;
            Second = second;
        }
    }
}
