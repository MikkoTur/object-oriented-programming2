using System;

namespace Book_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Jos kirja maksaa yli 30e, saat 10% alennuksen\n");

            Book uusiKirja1 = new Book("Nasse sedän muistot", "Jörgen Balls", "OTAVA", 35.99, "Elämänkerta");

            Console.WriteLine($"Tässä kirjailija tulostettu ominaisuudella. {uusiKirja1.Writer}");
            uusiKirja1.SearchBook(uusiKirja1);
            Book.ThemeChange();


            Book uusiKirja2 = new Book("Riitan Reseptit", "Seppo Jormakka", "Tokmanni", 9.99, "Ruokakirja");
            uusiKirja1.SearchBook(uusiKirja2);
            Book.ThemeChange();

            Book uusiKirja3 = new Book("Reitti Mokadishuun", "Aku Hirviniemi", "WSOY", 50.50, "Matkailu");
            uusiKirja1.SearchBook(uusiKirja3);
            Book.ThemeChange();


            Console.ReadKey();
        }
    }
}
