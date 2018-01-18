using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFirma
{
    class Firma
    {
        public string Title;
        public string Address;
        public string Phone;
        public double Outcome;
        public double Expense;

        //Constructor
        public Firma(string title, string address, string phone, double outcome, double expense)
        {
            Title = title;
            Address = address;
            Phone = phone;
            Outcome = outcome;
            Expense = expense;
        }

        //Constructor määritelmä
        public Firma()
        {
            Title = "Ei tiedossa";
            Address = "Ei tiedossa";
            Phone = "Ei tiedossa";
            Outcome = 0;
            Expense = 0;
        }

        //Kopiomuodostin
        public Firma(Firma company)
        {
            Title = company.Title;
            Address = company.Address;
            Phone = company.Phone;
            Outcome = company.Outcome;
            Expense = company.Expense;
        }

        //Method
        public void AskData()
        {
            Console.WriteLine($"Syötä yrityksesi tiedot: Nimi, Osoite, Puhelinnumero, Tulot ja Menot");
            Title = Console.ReadLine();
            Address = Console.ReadLine();
            Phone = Console.ReadLine();
            Outcome = double.Parse(Console.ReadLine());
            Expense = double.Parse(Console.ReadLine());
        }

        public void ShowCompanyInfo()
        {
            Console.WriteLine($"Yrityksen nimi on: {Title}\n" +
                $"Osoite: {Address}\n" +
                $"Puhelinnumero: {Phone}\n" +
                $"Tulot: {Outcome}\n" +
                $"Menot: {Expense}");

        }
        //Method firman voittoprosentti

        public void CompanyProfitCalculate()
        {
            double profit = (Outcome - Expense) / Expense * 100;

            Console.WriteLine($"Yrityksesi voittoprosentti on: {profit:f2}");

            if (profit < 100)
            {
                Console.WriteLine($"Yrityksesi tulos on kehno");
            }
            if (profit <= 300)
            {
                Console.WriteLine($"Yrityksesi tulos on tyydyttävä");
            }
            if (profit > 300)
            {
                Console.WriteLine($"Yrityksesi tulos on kiitettävä");
            }
        }
    }
}
