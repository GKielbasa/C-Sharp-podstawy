using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class ClassA
    {
        private static int instanceCount = 0;

        public ClassA() 
        {
            instanceCount++;
        }

        public static string GetInstanceCount()
        {
            return $"Typ: {typeof(ClassA).Name}, Liczba obiektów: {instanceCount}";
        }
    }
}
