
using Zadanie7.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Konto k1 = new Konto(123, "Jan Kowalski", new DateTime(2019, 10, 10));
        Konto k2 = new Konto(321, "Robert Kaczka", new DateTime(2000,1,1));

        Przelew p1 = new Przelew(DateTime.Now,"Za las",1000000,k1,k2);
        Console.WriteLine();
        p1.WypiszInfoTransakcji();

        //Co zrobić żeby metoda wyswietlZTransakcjami() z klasy Konto wykrywała rzeczywisty typ transakcji (np. przelew)?  - zastosowac mechanizm runtime type checking 
        // metoda ta sluzy do sprawdzani typu obiektu w czasie rzeczywistym 
        Console.WriteLine();
        Console.WriteLine("test wyswietlZrans");
        Przelew p2 = new Przelew(DateTime.Now,"Zaliczka",12343245,k2,k1);
        k1.DidajTransakcje(p1);
        k2.DidajTransakcje(p2);
        Console.WriteLine("trans na koncie 1");
        k1.wyswietlZTransakcjami();
        Console.WriteLine("trans na koncie 2");
        k2.wyswietlZTransakcjami();
    }
}