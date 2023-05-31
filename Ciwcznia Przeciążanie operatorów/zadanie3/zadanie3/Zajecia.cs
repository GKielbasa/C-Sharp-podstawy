using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    struct Zajecia
    {
        public string Nazwa { get; set; }
        public string SkrotNazwy { get; set; }
        public BlokiZajecWSB Godzina { get; set; }
        public int Sala { get; set; }
        public DzienTygodnia Dzien { get; set; }
        public FormaZaliczenia Zal { get; set; }

        public enum DzienTygodnia
        {
            Poniedzialek,
            Wtorek,
            Sroda,
            Czwartek,
            Piatek,
            Sobota,
            Niedziela
        }
        public enum FormaZaliczenia
        {
            Zaliczenie,
            Egzamin
        }

        public enum BlokiZajecWSB
        {
            Blok1, // 08:00-10:15
            Blok2, // 10:30-12:45
            Blok3, // 13:30-15:45
            Blok4, // 16:00-18:15
            Blok5  // 18:30-20:45
        }

        public Zajecia (string nazwa, string skrotNazwy, BlokiZajecWSB godzina, int sala, DzienTygodnia dzienTygodnia, FormaZaliczenia formaZaliczenia)
        {
            this.Nazwa = nazwa;
            this.SkrotNazwy = skrotNazwy;
            this.Godzina = godzina;
            this.Sala = sala;
            this.Dzien = dzienTygodnia;
            this.Zal = formaZaliczenia;
        }

        public void WypiszInfoOZajeciach()
           
        {
            string godziny = GetGodzinyBlokowZajecWSB(Godzina);
            Console.WriteLine($"Zajęcia  {Dzien}:\n\t{Nazwa}, ({SkrotNazwy})\n\tgodzina: {godziny}\n\tsala: {Sala}\n\tForma zaliczenia: {Zal} ");
        }
        private BlokiZajecWSB PrzekonwertujGodzine(string godzina)
        {
            switch (godzina)
            {
                case "08:00-10:15":
                    return BlokiZajecWSB.Blok1;
                case "10:30-12:45":
                    return BlokiZajecWSB.Blok2;
                case "13:30-15:45":
                    return BlokiZajecWSB.Blok3;
                case "16:00-18:15":
                    return BlokiZajecWSB.Blok4;
                case "18:30-20:45":
                    return BlokiZajecWSB.Blok5;
                default:
                    throw new ArgumentException("Nieprawidłowa wartość godziny");
            }
        }
        public string GetGodzinyBlokowZajecWSB(BlokiZajecWSB blok)
        {
            switch(blok)
            {
                case BlokiZajecWSB.Blok1:
                    return "08:00-10:15";
                case BlokiZajecWSB.Blok2:
                    return "10:30-12:45";
                case BlokiZajecWSB.Blok3:
                    return "13:30-15:45";
                case BlokiZajecWSB.Blok4:
                    return "16:00-18:15";
                case BlokiZajecWSB.Blok5:
                    return "18:30-20:45";
                default:
                    return string.Empty;
            }
        }

        public static void WypiszHarmonogram(Zajecia[] harmonogram)
        {
            foreach (Zajecia zajecia in harmonogram)
            {
                zajecia.WypiszInfoOZajeciach();
                Console.WriteLine();
            }
        }

        public static void WYpiszHarmonogramWedlugDniTygodnia(Zajecia[] harmonogram)
        {
            Array.Sort(harmonogram, (x, y) =>
            {
                int result = x.Dzien.CompareTo(y.Dzien);
                if (result == 0)
                    result = x.Godzina.CompareTo(y.Godzina);
                return result;
            });
            WypiszHarmonogram(harmonogram);
        }

        public static void WypiszharmonogramWedlugGodziny(Zajecia[] harmonogram)
        {
            Array.Sort(harmonogram, (x, y) =>
            {
                int result = x.Godzina.CompareTo(y.Godzina);
                if (result == 0)
                    result = x.Dzien.CompareTo(y.Dzien);
                return result;
            });
            WypiszHarmonogram(harmonogram);
        }
    }
}
