using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate int CompareDelegate<T>(T obj1, T obj2);
public delegate void SortDelegate<T>(List<T> list, CompareDelegate<T> compare);

namespace Zdarzenia
{
    public class Osoba
    {
        public string Imie { get; set; }   
        public string Nazwisko { get; set; }    
        public string Plec { get; set; }

        public virtual string ReakcjaNaZwolanieSpotkania()
        {
            return "Przyjdę na spotkanie";
        }
        public static int Compare(Osoba obj1, Osoba obj2)
        {
            return string.Compare(obj1.Nazwisko, obj2.Nazwisko);
        }
    }
}
