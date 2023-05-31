using System;

public class Program
{
    public static void Main(string[] args)
    {
        /*Napisz program definiujący listę liczb typu „int”. Zastosuj w tym celu kolekcję List<T>, inicjalizując ją podczas definicji.

       Dodaj do listy kilka nowych elementów i wyświetl jej zawartość.
        Następnie wstaw element w określone miejsce, dwa inne elementy wykasuj.Na koniec listę posortuj i ponownie wyświetl jej zawartość.*/

        List<int> list = new List<int> { 1, 6, 3, 0, 5 };

        list.Add(6);
        list.Add(7);
        list.Add(8);

        Console.WriteLine("Wypisanie listy: ");

        foreach (int element in list)
        {
            Console.Write($" {element}");
        }
        Console.WriteLine();

        list.Insert(3, 99);
        list.Insert(5, 22);
        Console.WriteLine("Lista po dodaniu elementów");
        foreach (int element in list)
        {
            Console.Write($" {element}");
        }

        list.Remove(99);
        list.RemoveAt(1);

        //list.Remove(4);

        Console.WriteLine("Lista po usunieciu elementów ");
        foreach (int element in list)
        {
            Console.Write($" {element}");
        }
        list.Sort();
        Console.WriteLine();
        Console.WriteLine("Lista posorotowana ");
        foreach (int element in list)
        {
            Console.Write($" {element}");
        }
    }
}