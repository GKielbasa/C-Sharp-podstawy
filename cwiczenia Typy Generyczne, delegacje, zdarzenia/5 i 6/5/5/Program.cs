using System;
using zadanie5.Models;
public class Program
{
    public static void Main(string[] args)
    {

        Towar t1 = new Towar("Łopata", 30.99m);
        Towar t3 = new Towar("Młotek", 23.50m);
        Towar t2 = new Towar("Gruszka", 19.20m);
        Towar t4 = new Towar("taczka", 100.20m);
        Towar t5 = new Towar("Deska", 40.20m);

        List<Towar> list = new List<Towar>();
        list.Add(t1);
        list.Add(t3);
        list.Add(t2);
        list.Add(t4);
        list.Add(t5);

        foreach (Towar t in list)
        {
            Console.WriteLine(t.ToString());
        }

        Osoba o1 = new Osoba("Jan", "Cymbal", "M");
        Osoba o2 = new Osoba("Anna", "Baran", "K");
        Osoba o3 = new Osoba("Jan", "Adam", "M");
        Osoba o4 = new Osoba("Adam", "Janusz", "M");
        Osoba o5 = new Osoba("Krzysek", "Robert", "M");

        List<Osoba> listaOsob = new List<Osoba>();
        listaOsob.Add(o1);
        listaOsob.Add(o2);
        listaOsob.Add(o3);
        listaOsob.Add(o4);
        listaOsob.Add(o5);
        Console.WriteLine();
        Console.WriteLine("Lista osob");
        foreach (Osoba o in listaOsob)
        {
            Console.WriteLine(o.ToString());
        }
        Console.WriteLine();
        Console.WriteLine("posorotwana lista osób : ");

        listaOsob.Sort();

        foreach (Osoba o in listaOsob)
        {
            Console.WriteLine(o.ToString());
        }
        Console.WriteLine();
        Console.WriteLine("lista przedmiotów po cenie ");

        list.Sort();
        foreach (Towar t in list)
        {
            Console.WriteLine(t.ToString());
        }
    }
}