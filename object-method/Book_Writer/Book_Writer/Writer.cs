using System;
using System.Collections.Generic;
using System.Text;
using Literature;

namespace Book_Writer
{
    class Writer
    {
        public string Name;
        public string Birthday;
        public string Book;

        public Writer(string name, string birthday, string book)
        {
            Name = name;
            Birthday = birthday;
            Book = book;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Kirjailijan nimi on {Name}\n" +
                $"Syntynyt {Birthday}\n" +
                $"Kirjoittanut {Book}\n" +
                $"--------------------");
        }
    }
}
