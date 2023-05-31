using zadanie7.Models;

public class Program
{
    public static void Main(string[] args)
    {


        
        Osoba osoba1 = new Osoba(1, "Anna Kowalska");
        Osoba osoba2 = new Osoba(2, "Jan Nowak");
        Osoba osoba3 = new Osoba(3, "Krzysztof Zalewski");

        
        Grupa grupa = new Grupa();
        grupa.DodajCzlonkaGrupy(osoba1);
        grupa.DodajCzlonkaGrupy(osoba2);
        grupa.DodajCzlonkaGrupy(osoba3);

      
        Osoba prowadzacy = new Osoba(4, "Piotr Prowadzący");

        
        Kurs kurs = new Kurs("Programowanie w C#", 30, prowadzacy);
        kurs.DodajGrupe(grupa);
        kurs.Wypisz();



    }
}