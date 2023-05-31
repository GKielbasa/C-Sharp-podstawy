
using zadanie5.Models;

public class Program
{
    public static void Main(string[] args)
    {
        List<Towar> towary = new List<Towar>
        {
            new Towar("Samochód", 50000m),
            new Towar("Telewizor", 1500m),
            new Towar("Telefon", 3000m),
            new Towar("Laptop", 4500m),
            new Towar("Lodówka", 2000m)
        };
        Console.WriteLine("Podaj początkowy tekst nazwy towaru:");
        string poczatekNazwy = Console.ReadLine();

        var wybraneTowary = towary
            .Where(towar => towar.Nazwa.StartsWith(poczatekNazwy, StringComparison.CurrentCultureIgnoreCase))
            .ToList();

        foreach (var towar in wybraneTowary)
        {
            Console.WriteLine(towar);
        }

        decimal sumaCen = wybraneTowary.Sum(towar => towar.Cena);
        Console.WriteLine($"Sumaryczna cena: {sumaCen} zł");

        Console.WriteLine("Podaj maksymalną cenę:");
        decimal maxCena;
        while (!decimal.TryParse(Console.ReadLine(), out maxCena))
        {
            Console.WriteLine("Nieprawidłowa wartość, spróbuj ponownie:");
        }

        var tanieTowary = towary
            .Where(towar => towar.Cena <= maxCena)
            .ToList();

        foreach (var towar in tanieTowary)
        {
            Console.WriteLine(towar);
        }

    }
}