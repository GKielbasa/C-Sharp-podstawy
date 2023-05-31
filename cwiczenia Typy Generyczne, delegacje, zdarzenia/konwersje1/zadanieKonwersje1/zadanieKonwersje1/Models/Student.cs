using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieKonwersje1.Models
{
    internal class Student : Osoba
    {

        private static int nextID = 0;


        public Student(string imieInazwisko, string nrTelefonu) : base(imieInazwisko)
        {
            this.NrTelefonu = nrTelefonu;
            this.id = ++nextID;

        }
        public override void wypiszOsobe()
        {
            Console.WriteLine("Student: ");
            base.wypiszOsobe();
        }
        public new static Student StworzOsobe(string imieINazwisko, string nrTelefonu)
        {
            return new Student(imieINazwisko, nrTelefonu);
        }
        public static implicit operator Student(Pracownik person)
        {
            return new Student(person.ImieINazwisko, person.NrTelefonu);
        }
    }
}
