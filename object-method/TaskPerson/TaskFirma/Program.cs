using System;

namespace TaskFirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Firma newfirma = new Firma();
            newfirma.AskData();
            newfirma.ShowCompanyInfo();
            newfirma.CompanyProfitCalculate();

            Console.ReadLine();
        }
    }
}
