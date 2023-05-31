using zadanie9.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Stos<int> stos = new Stos<int>();
        stos.Dodaj(1);
        stos.Dodaj(2);
        stos.Dodaj(3);
        Console.WriteLine($"Pierwszy element stosu: {stos.Pierwszy()}"); // powinno wyświetlić "3"
        stos.Usun();
        Console.WriteLine($"Pierwszy element stosu po usunięciu: {stos.Pierwszy()}"); // powinno wyświetlić "2"

        // FIFO testowe
        FIFO<int> fifo = new FIFO<int>();
        fifo.Dodaj(1);
        fifo.Dodaj(2);
        fifo.Dodaj(3);
        Console.WriteLine($"Pierwszy element kolejki: {fifo.Pierwszy()}"); // powinno wyświetlić "1"
        fifo.Usun();
        Console.WriteLine($"Pierwszy element kolejki po usunięciu: {fifo.Pierwszy()}"); // powinno wyświetlić "2"

        // Spróbujmy usunąć więcej elementów niż istnieje
        try
        {
            for (int i = 0; i < 10; i++)
            {
                stos.Usun();
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Wystąpił wyjątek podczas usuwania z stosu: {ex.Message}");
        }
    }
}