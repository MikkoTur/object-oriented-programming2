using System;
using System.Linq;
using Bankdb.Models;
using Bankdb.Repositories;

namespace Bankdb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa");
            BankRepository bankRepository = new BankRepository();
            Bank bank = new Bank();
            bank.Name = "Säästöpankki";
            bank.Bic = "ITELFIHH";
            bankRepository.Create(bank);

            Console.ReadLine();

        }
    }
}
