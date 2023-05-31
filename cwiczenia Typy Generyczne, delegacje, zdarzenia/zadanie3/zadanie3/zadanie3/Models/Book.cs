using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3.Models
{
    internal class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }

        public Book(string author, string title)
        {
            Author = author;
            Title = title;
        }
    }
}
