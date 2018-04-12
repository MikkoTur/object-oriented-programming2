using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Bankdb.Models;

namespace Bankdb.Repositories
{
    class AccountRepository
    {
        private readonly BankdbContext _context = new BankdbContext();

        public List<Account> Read()
        {
            List<Account> accounts = _context.Account.ToListAsync().Result;
            return accounts;
        }

        public Account GetAccountByIban(string iban)
        {
            var account = _context.Account.FirstOrDefault(a => a.Iban == iban);
            return account;
        }

        public void CreateAccount(Account account)
        {
            _context.Add(account);
            _context.SaveChanges();
        }

        public void DeleteAccount(string iban)
        {
            var delAccount = _context.Account.FirstOrDefault(a => a.Iban == iban);
            if (delAccount != null)
                _context.Account.Remove(delAccount);
            _context.SaveChanges();
        }

        public void AddTransaction(Transaction transaction)
        {
            using (var context = new BankdbContext())
            {
                try
                {
                    context.Add(transaction);
                    var account = GetAccountByIban(transaction.Iban);
                    //decimal balanceBeforeTransaction = account.Balance;
                    account.Balance += transaction.Amount;

                    //Update account-table
                    context.Account.Update(account);
                    //Tallennetaan muutokset tietokantaan
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
