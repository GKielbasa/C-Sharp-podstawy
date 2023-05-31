using System.Net;
using zadanie3.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Book[] ksiazki = new Book[]
        {
            new Book("Adam Mieckiewicz", "Dziady"),
            new Book("Jakis Typ", "Srednia ksiazka")
        };

        Student[] listaStudentow = new Student[]
        {
            new Student("Czesiek Janusz", 25),
            new Student("Jan Kara", 20)
        };
        Console.WriteLine("zestawienie ksiazek:");
        ZestawienieTabelaryczne<Book> zestawienie1 = new ZestawienieTabelaryczne<Book>(ksiazki);
        zestawienie1.GenerateReport();
        Console.WriteLine();
        Console.WriteLine("Zestawienie stuentów: ");
        ZestawienieTabelaryczne<Student> zestawienie2 = new ZestawienieTabelaryczne<Student>(listaStudentow); 
        zestawienie2.GenerateReport();
    }
}