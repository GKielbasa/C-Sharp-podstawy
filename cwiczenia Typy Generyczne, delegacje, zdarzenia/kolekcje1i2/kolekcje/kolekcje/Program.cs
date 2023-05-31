using Zdarzenia;

public class Program
{
    public static void Main(string[] args)
    {
        // Tworzenie instancji grupy
        Grupa<Osoba> grupa = new Grupa<Osoba>();

        // Dodawanie osób do grupy
        Osoba osoba1 = new Osoba { Imie = "Jan", Nazwisko = "Kowalski", Plec = "Mężczyzna", Wzrost = 180 };
        Osoba osoba2 = new Student { Imie = "Anna", Nazwisko = "Nowak", Plec = "Kobieta", Wzrost = 170 };
        Osoba osoba3 = new Pracownik { Imie = "Krzysztof", Nazwisko = "Zielinski", Plec = "Mężczyzna", Wzrost = 185 };

        grupa.DodajOsobe(osoba1);
        grupa.DodajOsobe(osoba2);
        grupa.DodajOsobe(osoba3);

        // Wywoływanie metody obliczającej średni wzrost członków grupy
        Console.WriteLine($"Średni wzrost członków grupy: {grupa.SredniWzrost()}");
    }
}