using System;

namespace Zdarzenia
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Eventy to specjalny typ delegatów, które służą do zapewnienia mechanizmu obsługi zdarzeń w C#. Zdarzenie to stan, który występuje w wyniku działań użytkownika 
               (kliknięcia, przeciągnięcia, naciśnięcia klawisza itp.) lub automatycznych procesów systemowych.
               Głównym celem zdarzeń jest umożliwienie klasie(lub klasom) wysłania powiadomienia innym klasom, gdy wystąpi pewne zdarzenie.
               Są one zazwyczaj używane do informowania o zmianie stanu obiektu.*/

            // Stworzenie obiektów różnych typów
            Osoba osoba = new Osoba { Imie = "Anna", Nazwisko = "Kowalska", Plec = "Kobieta" };
            Pracownik pracownik = new Pracownik { Imie = "Jan", Nazwisko = "Nowak", Plec = "Mężczyzna" };
            Student student = new Student { Imie = "Kasia", Nazwisko = "Wiśniewska", Plec = "Kobieta" };

            // Utworzenie grupy
            Grupa grupa = new Grupa();

            // Dodanie do grupy osób
            grupa.DodajOsobe(osoba);
            grupa.DodajOsobe(pracownik);
            grupa.DodajOsobe(student);

            // Podpięcie funkcji do zdarzenia SprawdzanieObecnosci
            grupa.SprawdzanieObecnosci += (o, msg) => Console.WriteLine(msg);

            // Sprawdzenie obecności
            grupa.SprawdzObecnosc();

            // Podpięcie funkcji do zdarzenia Spotkanie
            grupa.Spotkanie += (o, msg) => Console.WriteLine($"{o.Imie} {o.Nazwisko} - {msg}");

            // Zwołanie spotkania
            grupa.ZwolajSpotkanie("Spotkanie w sprawie projektu.");

            Console.ReadKey();
        }
    }
}
