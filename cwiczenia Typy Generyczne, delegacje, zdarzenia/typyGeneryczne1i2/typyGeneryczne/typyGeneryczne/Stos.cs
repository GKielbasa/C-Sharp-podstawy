using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typyGeneryczne
{
    internal class Stos<T>
    {
        private T[] elements;
        private int topIndex = -1;

        public Stos(int size)
        {
            elements = new T[size];
        }

        public void Push(T item)
        {
            if (topIndex == elements.Length - 1)
            {
                throw new InvalidOperationException("Stos jest pełny");
            }
            elements[++topIndex] = item;
        }

        public T Pop()
        {
            if (topIndex <0)
            {
                throw new InvalidOperationException("Stos jest pusty.");
            }
            T top = elements[topIndex];
            elements[topIndex--] = default(T);
            return top;
        }

        public T Top
        {
            get
            {
                if (topIndex < 0)
                {
                    throw new InvalidOperationException("Stos jest pusty.");
                }
                return elements[topIndex];
            }
        }
    }
}
