using System;
using System.Linq;
using Bankdb.Models;
using Bankdb.Repositories;
using Bankdb.View;

namespace Bankdb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Tervetuloa");
            //Pankin luominen/päivittäminen/poistaminen

            //BankRepository bankRepository = new BankRepository();
            //Bank bank = new Bank();
            //bank.Name = "Nordea";
            //bank.Bic = "ITELFIHH";
            //bankRepository.Delete(5);

            //Asiakkaan tiedot/luominen

            //CustomerRepository customerRepository = new CustomerRepository();
            //Customer customer = new Customer();
            //Create create = new Create();
            //create.KysyTiedot(customer);
            //Random rnd2 = new Random();
            //long bankid = 0;
            //for (long i = 0; i < 3; i++)
            //{
            //    bankid = rnd2.Next(1, 3);
            //}

            //customer.BankId = bankid;
            //customerRepository.Create(customer);
            //Customer addedCustomer = customerRepository.GetLastCustomer();
            //Tilin tiedot/luomien

            //AccountRepository accountRepository = new AccountRepository();
            //Random rnd = new Random();
            //string rndaccount = "FI";
            //for (int i = 0; i < 18; i++)
            //{
            //    rndaccount += rnd.Next(0, 10);
            //}
            //Account account = new Account();
            //account.Iban = rndaccount;
            //account.Name = $"{customer.Firstname} {customer.Lastname}";
            //account.BankId = bankid;
            //account.Balance = 0;
            //account.CustomerId = addedCustomer.Id;
            //accountRepository.CreateAccount(account);

            //Tilitapahtumien luominen

            //Transaction transaction = new Transaction
            //{
            //    Iban = rndaccount,
            //    Amount = 54321,
            //    TimeStamp = DateTime.Today
            //};
            //accountRepository.AddTransaction(transaction);

            ViewBank viewBank = new ViewBank();
            viewBank.PrintCustomer();

            //Kertoo kun ohjelma on valmis
            Console.WriteLine("Hello");

            Console.ReadLine();

        }
    }
}
