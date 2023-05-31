using zadanie3;

class Program
{
    public static void Main(string[] args)
    {

        Zajecia[] mojHarmonogram = new Zajecia[5];
        mojHarmonogram[0] = new Zajecia("Interakcja człowiek komputer", "IChK", Zajecia.BlokiZajecWSB.Blok4, 5, Zajecia.DzienTygodnia.Wtorek, Zajecia.FormaZaliczenia.Zaliczenie);
        mojHarmonogram[1] = new Zajecia("Rachunek różniczkowy i całkowy", "RRiC", Zajecia.BlokiZajecWSB.Blok2, 5, Zajecia.DzienTygodnia.Poniedzialek, Zajecia.FormaZaliczenia.Egzamin);
        mojHarmonogram[2] = new Zajecia("Programowanie w języku C#", "C#", Zajecia.BlokiZajecWSB.Blok3, 5, Zajecia.DzienTygodnia.Sroda, Zajecia.FormaZaliczenia.Egzamin);
        mojHarmonogram[3] = new Zajecia("Laboratorium Hack the box", "Lab HTB", Zajecia.BlokiZajecWSB.Blok5, 5, Zajecia.DzienTygodnia.Czwartek, Zajecia.FormaZaliczenia.Egzamin);
        mojHarmonogram[4] = new Zajecia("Inżynieria systemowa", "IS", Zajecia.BlokiZajecWSB.Blok1, 5, Zajecia.DzienTygodnia.Piatek, Zajecia.FormaZaliczenia.Zaliczenie);

        Zajecia.WypiszHarmonogram(mojHarmonogram);
        Console.WriteLine();
        Console.WriteLine("Według dni tygodnia :");
        Zajecia.WYpiszHarmonogramWedlugDniTygodnia(mojHarmonogram);
        Console.WriteLine();
        Console.WriteLine("Według godzin");
        Zajecia.WypiszharmonogramWedlugGodziny(mojHarmonogram);

    }
}