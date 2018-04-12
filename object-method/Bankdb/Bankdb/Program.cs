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
            //BankRepository bankRepository = new BankRepository();
            //Bank bank = new Bank();
            //bank.Name = "Osuuspankki";
            //bank.Bic = "OKOYFIHH";
            //bankRepository.Delete(4);

            //CustomerRepository customerRepository = new CustomerRepository();
            //Customer customer = new Customer();
            //customer.Firstname = "Juuso";
            //customer.Lastname = "Montonen";
            //customer.BankId = 2;
            //customerRepository.Create(customer);
            //CustomerRepository accountrepository = new CustomerRepository();
            //Account account = new Account();
            //account.Iban = "FI271827369789182736";
            //account.Name = "Juuso Montonen";
            //account.BankId = 4;
            //account.CustomerId = 4;
            //account.Balance = 69000;
            //accountrepository.Create(account);

            AccountRepository accountRepository = new AccountRepository();
            Transaction transaction = new Transaction
            {
                Iban = "FI201234432166619044",
                Amount = 100,
                TimeStamp = DateTime.Today
            };
            accountRepository.AddTransaction(transaction);

            Console.ReadLine();

        }
    }
}
