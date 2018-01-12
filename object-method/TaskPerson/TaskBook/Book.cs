using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBook
{
    class Book
    {
        //Kirjan tiedot
        public string Title;
        public string Author;
        public int Id;
        public double Price;


        public Book(string title, string author, int id, double price)
        {
            Title = title;
            Author = author;
            Id = id;
            Price = price;
        }

        public void PrintBookInfo()
        {
            Console.WriteLine($"Kirjan nimi: {Title}\n" +
                $"Kirjailija: {Author}\n" +
                $"Id-Numero: {Id}\n" +
                $"Hinta: {Price}\n");
        }

        public string CompareBook(Book book)
        {
            if (this.Price > book.Price)
                return ($"{this.Title} on kalliimpi kuin {book.Title} kirja\n");
            else
                return ($"{book.Title} on kalliimpi kuin {this.Title} kirja\n");

        }
    }
}
