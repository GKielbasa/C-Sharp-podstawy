using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    public class Grupa
    {
        public event Action<Osoba, string> SprawdzanieObecnosci;
        public event Action<Osoba, string> Spotkanie;
        public List<Osoba> Osoby { get; set; }

        public Grupa()
        {
            Osoby = new List<Osoba>();
        }

        public void DodajOsobe(Osoba osoba)
        {
            Osoby.Add(osoba);
        }

        public void SprawdzObecnosc()
        {
            foreach (var osoba in Osoby)
            {
                SprawdzanieObecnosci?.Invoke(osoba, $"{osoba.Imie}, {osoba.Nazwisko} obecny !"); // metoda invoke jest wywoływana do wywołania zdarzenia
            }
        }

        public void ZwolajSpotkanie(string opisSpotkania)
        {
            foreach (var osoba in Osoby)
            {
                Spotkanie?.Invoke(osoba, $"{osoba.ReakcjaNaZwolanieSpotkania()}");
            }
        }

        public void Sortuj(SortDelegate<Osoba> sort, CompareDelegate<Osoba> compare)
        {
            sort(Osoby, compare);
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
    }
}
