
using ConsoleApp1;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        var genericInt = new GenericClass<int>();
        genericInt.Property = 10;
        genericInt.PrintType();

        var genericString = new GenericClass<string>();
        genericString.Property = "test";
        genericString.PrintType();

        //ZAD 2
        int libcza1 = 1;
        var libcza2 = 2;
        Console.WriteLine($"Przed: {libcza1} : {libcza2}");
        Swap(ref libcza1, ref libcza2);
        Console.WriteLine($"Po: {libcza1} : {libcza2}");

        var string1 = "jakis";
        string string2 = "string";
        Console.WriteLine($"Przed: {string1} : {string2}");
        Swap(ref string1, ref string2);
        Console.WriteLine($"Po: {string1} : {string2}");
        Console.WriteLine();
        Console.WriteLine("Teraz test metody zamieniajacej stany  obiektów generycznych");
        var genericInt2 = new GenericClass<int>();
        genericInt2.Property = 20;
        Console.WriteLine($"Przed zamianą: {genericInt.Property} : {genericInt2.Property}");
        genericInt.SwapWithAnotherType(genericInt2);
        Console.WriteLine($"Po zamianie: {genericInt.Property} : {genericInt2.Property}");




    }
    public static void Swap<T>(ref T first, ref T second)
    {
        //Zadanie 2 cd zadania zamieniajacy pypy naszych generycznych obiektów w klasie GenericClass
        /*Metoda generyczna to taka, która operuje na parametrach określonego typu. Typ ten nie jest jednak określany na sztywno,
         * lecz jest wybierany w momencie korzystania z metody.*/
        T tmp = first;
        first = second;
        second = tmp;
    }
    
}