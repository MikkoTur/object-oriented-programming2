using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Writer
{
    class Book
    {
        public string Name;
        public string Writer;
        public string Publisher;
        public double Price;
        public string Theme;

        static string ChangeTheme;

        //Constructor
        public Book()
        {
            Name = "Unknown";
            Writer = "Unknown";
            Publisher = "Unknown";
            NewPrice = 0;
            Theme = "Unknown";
        }



        public Book(string Name, string Writer, string Publisher, double Price, string Theme)
        {
            this.Name = Name;
            this.Writer = Writer;
            this.Publisher = Publisher;
            this.Price = Price;
            this.Theme = Theme;

        }
        public Book(Book book)
        {
            this.Name = book.Name;
            this.Writer = book.Writer;
            this.Publisher = book.Publisher;
            this.Price = book.Price;
            this.Theme = book.Theme;

        }

        //Methods

        public void SearchBook(Book book)
        {
            if (this.Name.Equals(book.Name))
                Console.WriteLine($"{book.Name}\n" +
                    $"{book.Writer}\n" +
                    $"{book.Publisher}\n" +
                    $"{book.Price}\n" +
                    $"{book.Theme}\n");
            else
                Console.WriteLine($"Kirjaa: {book.Name}, ei löytynyt");
        }

        public void SearchBook(string name)
        {
            if (Name.Equals(name))
                Console.WriteLine($"{Name}\n" +
                    $"{Writer}\n" +
                    $"{Publisher}\n" +
                    $"{Price}\n" +
                    $"{Theme}\n");
            else
                Console.WriteLine($"Kirjaa: {Name}, ei löytynyt");
        }


        public double NewPrice
        {
            get
            {
                return Price;
            }
            set
            {
                if (value > 30)
                {
                    Price = value * 0.9;
                    Console.WriteLine($"Kirjan {Name} uusi hinta on {Price}");
                }
            }
        }



        public static void ThemeChange()
        {
            Console.WriteLine(ChangeTheme);
        }
    }
}
