using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie9.Models
{
    internal class RandomUtility
    {
        private static Random random = new Random();

        public static int RandInt(int a, int b)
        {
            return random.Next(a, b);
        }
        public static double RandDouble(double a, double b)
        {
            return a + (random.NextDouble() * (b-a));
        }
        public static decimal RandomDecimal(decimal a, decimal b)
        {
            double aDouble = Convert.ToDouble(a);
            double bDouble = Convert.ToDouble(b);
            
            double randDouble = aDouble + (random.NextDouble() * (bDouble- aDouble));

            return Convert.ToDecimal(randDouble);
        }
        public static string RandomString (int n)
        {
            string znaki = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[n];

            for (int i = 0; i< stringChars.Length; i++)
            {
                stringChars[i] = stringChars[random.Next(stringChars.Length)];
            }
            return new string(stringChars);
        }

        public static T[] RandomFromArray<T>(int n, T[] array, bool pwt)
        {
            T[] result = new T[n];
            for (int i=0; i< n; i++)
            {
                int randIndex = random.Next(array.Length);
                result[i] = array[randIndex];
                if (!pwt)
                {
                    array = array.Where((source, index) => index != randIndex).ToArray();
                }
            }
            return result;
        }
    }
}
