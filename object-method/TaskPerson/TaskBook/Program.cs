using System;

namespace TaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Book newBook = new Book("Dabbers", "Seppo Aho", 1234567, 29.99);
            newBook.PrintBookInfo();

            Book newBook2 = new Book("Lit", "Lil Pump", 7654321, 45.99);
            newBook2.PrintBookInfo();

            Book newBook3 = new Book("How to be Atte", "Atte Peltonen", 7657231, 14.99);
            newBook3.PrintBookInfo();

            Console.WriteLine($"{newBook2.CompareBook(newBook)}");
            Console.WriteLine($"{newBook3.CompareBook(newBook)}");

            Console.ReadKey();
        }
    }
}
