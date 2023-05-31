using zadanie2;

public class Program
{
    public static void Main(string[] args)
    {
        
        LWymierna liczba1 = new LWymierna(6, 8);  
        LWymierna liczba2 = new LWymierna(14);     
        LWymierna liczba3 = new LWymierna();       

        
        liczba1.wypiszUlamek();
        liczba2.wypiszUlamek();
        liczba3.wypiszUlamek();
        //dodawanie 
        LWymierna suma = liczba1 + liczba2;
        suma.wypiszUlamek();

        //odejmowanie 
        LWymierna roznica = liczba1 - liczba2;
        roznica.wypiszUlamek();

       //mnożenie 
        LWymierna iloczyn = liczba1 * liczba2;
        iloczyn.wypiszUlamek();

        //dzielenie
        LWymierna iloraz = liczba1 / liczba2;
        iloraz.wypiszUlamek();

        // zamiana na -
        LWymierna przeciwna = -liczba1;
        przeciwna.wypiszUlamek();

        //  porównania
        Console.WriteLine(liczba1 < liczba2);   // Czy 17/2 < 14
        Console.WriteLine(liczba1 > liczba2);   // Czy 17/2 > 14
    
    }
}