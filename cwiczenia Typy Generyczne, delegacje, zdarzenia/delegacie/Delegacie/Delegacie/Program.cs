public class Program
{
    public delegate string TwoArgDelegate(string arg1, int arg2);

    //append string  
    public static string AppendIntToEndOfString(string text, int number)
    {
        return text + number.ToString();
    }
    //powtarzanie stringa
    public static string RepeatStringGivenTime(string text,int count)
    {
        string result = "";
        for (int i=0; i<count; i++)
        {
            result += text;
        }
        return result;
    }
    //return given about of chars 
    public static string GetCharsPrefix(string text, int amount)
    {
        return text.Substring(0, Math.Min(amount, text.Length));
    }
    public static void Main(string[] args)
    {
        // Utworzenie obiektów delegacji i wywołanie każdej metody
        TwoArgDelegate appendNumberDelegate = AppendIntToEndOfString;
        Console.WriteLine(appendNumberDelegate("Test", 5));  // Output: Test5

        TwoArgDelegate repeatStringDelegate = RepeatStringGivenTime;
        Console.WriteLine(repeatStringDelegate("Test", 5));  // Output: TestTestTestTestTest

        TwoArgDelegate getStringPrefixDelegate = GetCharsPrefix;
        Console.WriteLine(getStringPrefixDelegate("Test", 2));  // Output: Te

        // Test zarejestrowania wszystkich metod do jednej delegacji
        TwoArgDelegate multiDelegate = AppendIntToEndOfString;
        multiDelegate += RepeatStringGivenTime;
        multiDelegate += RepeatStringGivenTime;

        // Wywołanie delegacji zarejestrowanej do wielu metod spowoduje wykonanie wszystkich metod po kolei, 
        // ale zwróci wynik tylko ostatniej zarejestrowanej metody
        Console.WriteLine(multiDelegate("Test", 2));  


    }
}