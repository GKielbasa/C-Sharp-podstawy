using kolekcje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    public class Grupa<T> where T : IWypisz
    {
        public event Action<Osoba, string> SprawdzanieObecnosci;
        public event Action<Osoba, string> Spotkanie;
        public SortedDictionary<string, Osoba> Osoby { get; set; }
        public SortedDictionary<string, T> Elementy { get; set; }


        public Grupa()
        {
            Osoby = new SortedDictionary<string, Osoba>(); 
        }

        public void DodajOsobe(Osoba osoba)
        {
            Osoby[osoba.Nazwisko] = osoba; // dodawanie do słownika
        }

          

        public static void InsertSort<T>(List<T> list, CompareDelegate<T> compare)
        {
            for (int i = 1; i < list.Count; i++)
            {
                var key = list[i];
                int j = i - 1;

                while (j >= 0 && compare(list[j], key) > 0)
                {
                    list[j + 1] = list[j];
                    j--;
                }

                list[j + 1] = key;
            }
        }
        public double SredniWzrost()
        {
            double suma = 0;
            foreach (var osoba in Osoby)
            {
                suma += osoba.Value.Wzrost;
            }
            return suma / Osoby.Count;
        }

    }
}
