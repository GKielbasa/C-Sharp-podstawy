using zadanieKowersje2.Models;

public class Program
{
    public static void Main(string[] args)
    {
        // Test konwersji jawnej Wektor -> double
        Wektor wektor = new Wektor(3, new double[] { 1.0, 2.0, 3.0 });
        double sumaWspolrzednych = (double)wektor; // powinno dać 6.0
        Console.WriteLine(sumaWspolrzednych == 6.0 ? "Test 1 passed" : "Test 1 failed");

        // Test konwersji niejawnej double -> Wektor
        double liczba = 5.0;
        wektor = liczba; // powinno stworzyć Wektor z jedną współrzędną o wartości 5.0
        Console.WriteLine(wektor.liczbaWspolrzednych == 1 && wektor.wspolrzedne[0] == 5.0 ? "Test 2 passed" : "Test 2 failed");

        // Test operacji na Wektorze
        Wektor wektor1 = new Wektor(3, new double[] { 1.0, 2.0, 3.0 });
        Wektor wektor2 = new Wektor(3, new double[] { 4.0, 5.0, 6.0 });
        Wektor sumaWektorow = wektor1 + wektor2; // powinno dać Wektor z współrzędnymi { 5.0, 7.0, 9.0 }
        Console.WriteLine(sumaWektorow.wspolrzedne.SequenceEqual(new double[] { 5.0, 7.0, 9.0 }) ? "Test 3 passed" : "Test 3 failed");
    }
}