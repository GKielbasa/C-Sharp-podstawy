using zadanieKonwersje1.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student("Jan Kowalski", "123456789");
        Pracownik pracownik = new Pracownik("Andrzej Strzelba", "987654321");

        
        student.wypiszOsobe();
        //jawna
        Pracownik pracownikJawna = (Pracownik)student;
        
        pracownikJawna.wypiszOsobe();
        Console.WriteLine();

        Student nowyStudent = pracownik;
        nowyStudent.wypiszOsobe();
    }
}