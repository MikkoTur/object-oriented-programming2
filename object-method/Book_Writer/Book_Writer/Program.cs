using System;
using Literature;

namespace Book_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Jos kirja maksaa yli 30e, saat 10% alennuksen\n");

            Writer uusiKirjailija1 = new Writer("Jörgen Balls", "26.06.1956", "Nasse sedän muistot");
            uusiKirjailija1.PrintInfo();
            Book uusiKirja1 = new Book("Nasse sedän muistot", "Jörgen Balls", "OTAVA", 35.99, "Elämänkerta");
            Console.WriteLine($"Tässä kirjailija tulostettu ominaisuudella. {uusiKirja1.Writer}");
            uusiKirja1.SearchBook(uusiKirja1);
            Book.ThemeChange();

            Writer uusiKirjailija2 = new Writer("Seppo Jormakka", "16.11.1944", "Riitan Reseptit");
            uusiKirjailija2.PrintInfo();
            Book uusiKirja2 = new Book("Riitan Reseptit", "Seppo Jormakka", "Tokmanni", 9.99, "Ruokakirja");
            uusiKirja1.SearchBook(uusiKirja2);

            Writer uusiKirjailija3 = new Writer("Aku Hirviniemi", "08.08.1988", "Reitti Mokadishuun");
            uusiKirjailija3.PrintInfo();
            Book uusiKirja3 = new Book("Reitti Mokadishuun", "Aku Hirviniemi", "WSOY", 50.50, "Matkailu");
            uusiKirja1.SearchBook(uusiKirja3);

            Console.ReadKey();
        }
    }
}
