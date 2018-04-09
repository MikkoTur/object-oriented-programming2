using System;
using System.Collections.Generic;
using System.Text;
using Bankdb.Models;

namespace Bankdb.Repositories
{
    interface IBank
    {
        Bank GetBankById(long id);
        void Create(Bank bank);
        void Update(Bank bank);
        void Delete(int Id);
    }
}
