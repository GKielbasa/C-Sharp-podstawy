using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typyGeneryczne
{
    internal class Test
    {
        public static Para<T>[] CreatePairsFromArray<T>(T[] array) where T : class
        {
            Para<T>[] pairs = new Para<T>[array.Length / 2 + array.Length % 2];

            for (int i = 0; i < array.Length; i+=2) 
            {
                T frist = array[i];
                T second = i +1 < array.Length ? array[i+1] : null;
                pairs[i / 2] = new Para<T>(frist, second);
            }
            return pairs;
        }
    }
}
