using System;
using System.Collections.Generic;
using System.Text;
using Bankdb.Models;
using Bankdb.Repositories;

namespace Bankdb.Repositories
{
    interface IAccount
    {
        List<Bank> GetBanks();
        List<Bank> GetBankCustomers();
        List<Bank> GetBankAccounts();
        void Create(Account account);
        void Update(string iban, Account account);
        void Delete(int iban);
    }
}