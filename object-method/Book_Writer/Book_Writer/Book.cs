using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Writer
{
    class Book
    {
        public string Name;
        private string _writer;
        public string Publisher;
        public double Price;
        public string Theme;
        private double newPrice;

        static string ChangeTheme;

        //Constructor
        public Book()
        {
            Name = "Unknown";
            _writer = "Unknown";
            Publisher = "Unknown";
            Price = 0;
            Theme = "Unknown";
        }



        public Book(string Name, string Writer, string Publisher, double Price, string Theme)
        {
            this.Name = Name;
            this._writer = Writer;
            this.Publisher = Publisher;
            this.Price = Price;
            this.Theme = Theme;
            NewPrice = Price;

        }
        public Book(Book book)
        {
            this.Name = book.Name;
            this._writer = book.Writer;
            this.Publisher = book.Publisher;
            this.Price = book.Price;
            this.Theme = book.Theme;

        }

        //Methods

        public void SearchBook(Book book)
        {
            if (this.Name.Equals(book.Name))
                Console.WriteLine("Kirja löytyi!");

            else
            {
                Console.WriteLine($"Kirjaa: {book.Name}, ei löytynyt");
            }
            Console.WriteLine($"{book.Name}\n" +
            $"{book.Writer}\n" +
            $"{book.Publisher}\n" +
            $"{book.Price}\n" +
            $"{book.Theme}\n");
            if (book.Price > 30)
                Console.WriteLine($"Alennettu hinta on: {book.NewPrice:C}\n");
            Console.WriteLine("---------------------------------");

        }
        // BookInfo
        public void SearchBook(string name)
        {
            if (Name.Equals(name))
                PrintBook();

            else
            {
                Console.WriteLine($"Kirjaa: {Name}, ei löytynyt");
                PrintBook();
            }
        }
        public void PrintBook()
        {
            Console.WriteLine($"{Name}\n" +
                              $"{Writer}\n" +
                              $"{Publisher}\n" +
                              $"{Price}\n" +
                              $"{Theme}\n");
        }


        public double NewPrice
        {
            get
            {
                return newPrice;
            }
            set
            {
                if (value > 30)
                {
                    newPrice = value * 0.9;
                    //Console.WriteLine($"Kirjan {Name} uusi hinta on {Price}");
                }
            }
        }

        public string Writer { get => _writer;
            //set => _writer = value;
        }

        public static void ThemeChange()
        {
            Console.WriteLine(ChangeTheme);
        }
    }
}
