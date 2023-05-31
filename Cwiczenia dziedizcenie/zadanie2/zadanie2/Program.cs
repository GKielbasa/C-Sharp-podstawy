using System;
using zadanie2.Models;
class Program
{
    static void Main(string[] args)
    {
       Trojkat t1 = new Trojkat("Trojkat", "Czerwony", "Czarny", 3, 4, 5);
       Trojkat t2 = new Trojkat("Trojkat", "Czarny","Zielony",5,6,7);

        Prostokat p1 = new Prostokat("Prostokat", "Czerwony", "Czarny", 3, 4);
        Prostokat p2 = new Prostokat("Prostokat", "Czarny", "Zielony", 5, 6);

        t1.Obwod();
        t1.Pole();       
        t2.Obwod();       
        t2.Pole();

        p1.Obwod();
        p1.Pole();
        p2.Obwod(); 
        p2.Pole();


    }
}