using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie9.Models;

namespace Zadanie9.Models
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
    }
}
