using Wyjątki;
using zad8.Models;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            double[] dane1 = new double[] { 1, 2, 3 };
            double[] dane2 = new double[] { 4, 5, 6, 7 };
            Wektor v1 = new Wektor(3, dane1);
            Wektor v2 = new Wektor(4, dane2);
            Wektor v3 = v1 + v2;
        }
        catch (InneWymiaryException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Wystąpił błąd: " + e.Message);
        }
    }
}