using zadanie6.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Konto k1 = new Konto(1234567,"Jan Kowalski",new DateTime(2022,1,22));
        
        string test = k1.ToString();
        Console.WriteLine(test);
        Console.WriteLine(); 
        k1.wypiszInfoOKoncie();

        Transakcja t1 = new Transakcja(DateTime.Now, "Za las", 1000);

        t1.WypiszInfoTransakcji();

        k1.DidajTransakcje(t1);

        k1.wypiszInfoOKoncie();
    }
}