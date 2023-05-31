using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie9.Models
{
    internal class Stos<T> : IKolejkowate<T> 
    {
        private List<T> elements = new List<T>();

        public Stos()
        {
            elements = new List<T>();
        }

        public void Dodaj(T item)
        {
            elements.Add(item);
        }
        public void Usun()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Stos jest pustyy.");
            }
            
            elements.RemoveAt(elements.Count - 1);      
            
        }

        public T Pierwszy()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Stos jest pusty.");
            }
            return elements[^1]; // ^ odwojujemy się od konca czyli w tym pryzpadku pierwszy element od konca 
        }
    }
}
