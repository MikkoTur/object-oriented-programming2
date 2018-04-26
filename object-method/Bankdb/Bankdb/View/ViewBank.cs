using System;
using System.Collections.Generic;
using Bankdb.Models;
using System.Data.SqlTypes;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using static Bankdb.Repositories.CustomerRepository;
using Bankdb.Repositories;

namespace Bankdb.View
{
    class ViewBank
    {
        private readonly CustomerRepository customerRepository = new CustomerRepository();
        private readonly BankRepository bankRepository = new BankRepository();

        public void PrintCustomer()
        {
            Console.WriteLine("Pankkien asiakkaat\n");
            var customers = customerRepository.GetCustomers();
            foreach (var c in customers)
            {
                Console.WriteLine(c.ToString());
            }
        }
        public void PrintBank()
        {
            Console.WriteLine("Pankit: \n");
            var banks = bankRepository.GetBanks();
            foreach (var b in banks)
            {
                Console.WriteLine(b.ToString());
            }
        }
        public void PrintTransaction()
        {
            Console.WriteLine("Pankkitapahtumat: \n");
            try
            {
                bankRepository.GetTransactionsFromBankCustomersAccounts();
                foreach (var bank in bankRepository.GetTransactionsFromBankCustomersAccounts())
                {
                    Console.WriteLine(bank.ToString());
                    foreach (var customer in bank.Customer)
                    {
                        Console.WriteLine(customer.ToString());
                        foreach (var account in customer.Account)
                        {
                            Console.WriteLine(account.ToString());
                            foreach (var transaction in account.Transaction)
                            {
                                Console.WriteLine(transaction.ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new NotImplementedException($"{e.Message}");
            }

        }
    }
}
