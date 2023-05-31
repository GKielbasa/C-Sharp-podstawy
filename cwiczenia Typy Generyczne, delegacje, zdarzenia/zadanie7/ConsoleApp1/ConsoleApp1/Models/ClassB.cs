using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class ClassB
    {
        private static int incanceCount = 0;

        public ClassB() 
        {
            incanceCount++;
        }

        public static string GetInstanceInfo ()
        {
            return $"Typ: {typeof(ClassB).Name}, Liczba obiektów: {incanceCount}";
        }
    }
}
