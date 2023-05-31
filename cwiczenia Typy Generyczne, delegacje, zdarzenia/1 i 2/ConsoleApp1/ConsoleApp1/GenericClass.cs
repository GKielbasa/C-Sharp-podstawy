using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GenericClass<T>
    {

        /*Klasy generyczne to jedno z fundamentalnych narzędzi w programowaniu typu ogólnego (ang. generic programming) w C#. Pozwalają one na utworzenie klasy lub metody, 
        które mogą operować na różnych typach danych. Dzięki temu nie musimy tworzyć oddzielnych klas dla różnych typów danych, co zwiększa reużywalność kodu.*/
        private T pole;
        public T Property { get; set; }

        public void PrintType ()
        {
            Console.WriteLine($"Typ: {typeof(T).Name}, wartość: {pole}, właściwość: {Property}");
        }

        public void SwapWithAnotherType<TOther>(GenericClass<TOther> other)
        {
            var temp = Property;
            Property = (T)Convert.ChangeType(other.Property, typeof(T));
            other.Property = (TOther)Convert.ChangeType(temp, typeof(TOther));
        }





    }
}
