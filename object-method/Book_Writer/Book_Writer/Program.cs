using System;

namespace Book_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Book uusiKirja1 = new Book("Nasse sedän muistot", "Jörgen Balls", "OTAVA", 35.99, "Elämänkerta");
            uusiKirja1.SearchBook(uusiKirja1);
            uusiKirja1.NewPrice = 35.99;
            Book.ThemeChange();

            Console.WriteLine("-------------------------------------");


            Book uusiKirja2 = new Book("Riitan Reseptit", "Seppo Jormakka", "Tokmanni", 9.99, "Ruokakirja");
            uusiKirja2.SearchBook(uusiKirja1);
            uusiKirja2.NewPrice = 9.99;
            Book.ThemeChange();


            Console.WriteLine("-------------------------------------");

            Book uusiKirja3 = new Book("Reitti Mokadishuun", "Aku Hirviniemi", "WSOY", 50.50, "Matkailu");
            uusiKirja1.SearchBook(uusiKirja3);
            uusiKirja3.NewPrice = 50.50;
            Book.ThemeChange();


            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Kirja löytyi!");
            string searchBook = "Nasse sedän muistot";
            uusiKirja1.SearchBook(searchBook);


            Console.ReadKey();
        }
    }
}
