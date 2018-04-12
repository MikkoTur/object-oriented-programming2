using System;
using System.Collections.Generic;
using System.Text;
using Bankdb.Models;
using Bankdb.Repositories;

namespace Bankdb.Repositories
{
    interface ICustomer
    {
        List<Bank> GetBanks();
        List<Bank> GetBankCustomers();
        List<Bank> GetBankAccounts();
        void Create(CustomerRepository customer);
        void Create(Account account);
        void Delete(int id);
    }
}
