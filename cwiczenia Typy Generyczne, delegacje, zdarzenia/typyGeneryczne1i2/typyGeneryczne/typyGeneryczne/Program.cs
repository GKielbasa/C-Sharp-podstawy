using typyGeneryczne;

public class Program
{
    public static void Main(string[] args)
    {
        Osoba[] osoby = new Osoba[]
{
    new Osoba("Jan", "Kowalski"),
    new Osoba("Anna", "Nowak"),
    new Osoba("Adam", "Szczepaniak"),
    new Osoba("Ewa", "Zielińska"),
    new Osoba("Michał", "Wójcik")
};

        Para<Osoba>[] pary = Test.CreatePairsFromArray(osoby);

        foreach (var para in pary)
        {
            Console.WriteLine($"Para: {para.First} i {para.Second}");
        }
    }
}