using zadanie4.Models;

class Program
{
    public static void Main(string[] args)
    {
        // Tworzenie wektorów
        double[] dane1 = { 1, 2, 3 };
        Wektor v1 = new Wektor(3, dane1);

        double[] dane2 = { 4, 5, 6 };
        Wektor v2 = new Wektor(3, dane2);

        // Wyświetlanie wektorów
        Console.WriteLine("Wektor v1:");
        v1.show();
        Console.WriteLine("Wektor v2:");
        v2.show();

        // Dodawanie wektorów
        Wektor suma = v1 + v2;
        Console.WriteLine("Suma v1 + v2:");
        suma.show();

        // Mnożenie wektora przez liczbę
        double skalar = 2.5;
        Wektor skalowany = v1 * skalar;
        Console.WriteLine($"Wektor v1 * {skalar}:");
        skalowany.show();

        // Iloczyn skalarny
        double iloczynSkalarny = v1 * v2;
        Console.WriteLine("Iloczyn skalarny v1 * v2:");
        Console.WriteLine(iloczynSkalarny);
    }
}