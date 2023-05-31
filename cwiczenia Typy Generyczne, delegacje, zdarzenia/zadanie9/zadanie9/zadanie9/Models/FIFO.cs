using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie9.Models
{
    internal class FIFO<T> : IKolejkowate<T>
    {
        private List<T> kolejkaFIFO;

        public FIFO()
        {
            kolejkaFIFO = new List<T>();
        }
        public void Dodaj(T item)
        {
            kolejkaFIFO.Add(item);
        }
        public void Usun()
        {
            if (kolejkaFIFO.Count == 0)
            {
                throw new InvalidOperationException("Kolejka jest pusta");
            }
            kolejkaFIFO.RemoveAt(0);
        }
        public T Pierwszy()
        {
            if (kolejkaFIFO.Count == 0)
            {
                throw new InvalidOperationException("Kolejka jest pusta");
            }
            return kolejkaFIFO[0];
        }
    }
}
