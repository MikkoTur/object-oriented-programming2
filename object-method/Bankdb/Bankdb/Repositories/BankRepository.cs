using System;
using System.Collections.Generic;
using System.Text;
using Bankdb.Models;
using System.Linq;

namespace Bankdb.Repositories
{
    class BankRepository : IBank
    {
        private readonly BankdbContext _context = new BankdbContext();
        public void Create(Bank bank)
        {
            _context.Bank.Add(bank);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var delBank = _context.Bank.FirstOrDefault(p => p.Id == id);
            if (delBank != null)
                _context.Bank.Remove(delBank);
            _context.SaveChanges();
        }
        public Bank GetBankById(long id)
        {
            var bank = _context.Bank.FirstOrDefault(p => p.Id == id);
            return bank;
        }

        public void Update(Bank bank)
        {
            var updateBank = GetBankById(bank.Id);
            if (updateBank != null)
            {
                updateBank.Name = bank.Name;
                _context.Bank.Update(updateBank);
            }
            _context.SaveChanges();
        }
    }
}
