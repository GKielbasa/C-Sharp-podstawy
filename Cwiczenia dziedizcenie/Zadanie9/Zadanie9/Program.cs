
using zadanie9.Models;
using Zadanie9.Models;

public class Program
{
    public static void Main(string[] args)
    {
        //    Student s4 = new Student("Jozin z bazin", "342872346753426");
        //    Console.WriteLine("s4:"); s4.wypiszOsobe();
        //    Console.WriteLine();
        //    Console.WriteLine("o1");
        //    Osoba o1 = new Osoba("Jan Kowalski", "12345678");
        //    Osoba o2 = new Osoba("Jan Kowalski", "12345678");
        //    Osoba o3 = new Osoba("Jan Kowalski", "12345678");
        //    Osoba o4 = new Osoba("Jan Kowalski", "12345678");
        //    o1.wypiszOsobe();
        //    o3.wypiszOsobe();
        //    Pracownik p1 = new Pracownik("Jakis tam", "98765432");
        //    Pracownik p2 = new Pracownik("Jakis tam", "98765432");
        //    Console.WriteLine();
        //    p1.wypiszOsobe();
        //    Student s1 = new Student("Jozin z bazin", "342872346753426");
        //    Student s2 = new Student("Jozin z bazin", "342872346753426");
        //    Student s3 = new Student("Jozin z bazin", "342872346753426");       
        //    s2.wypiszOsobe();     
        //    Console.WriteLine(); // Nie działa bo pole statyczne odnosi sie do calej klasy i jest inkrementowane dla wszytkich klas

        //Fabryka obiektów 
       
        Osoba o1 = Osoba.StworzOsobe("Jan Kowalski", "12345678");
        Osoba o2 = Osoba.StworzOsobe("Jan Kowal", "12345678");
        Student s1 = Student.StworzOsobe("Jozin z bazin", "342872346753426");
        Pracownik p1 = Pracownik.StworzOsobe("Jakis tam", "98765432");
        Student s2 = Student.StworzOsobe("Jozin z bazin", "342872346753426");
        Pracownik p2 = Pracownik.StworzOsobe("Jakis tam", "98765432");
        
        
        Student s3 = Student.StworzOsobe("Jozin z bazin", "342872346753426");

        Console.WriteLine("o1:");
        o1.wypiszOsobe();
        Console.WriteLine("s1");
        s2.wypiszOsobe();
        Console.WriteLine("p1");
        p1.wypiszOsobe();
        
    }
}