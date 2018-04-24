using System;
using System.Collections.Generic;
using Bankdb.Models;
using System.Data.SqlTypes;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Bankdb.Repositories
{
    class Create : Customer
    {
        public void KysyTiedot(Customer c)
        {
            Console.Write($"Syötä etunimi:");
            c.Firstname = Console.ReadLine();
            Console.WriteLine($"Syötä sukunimi:");
            c.Lastname = Console.ReadLine();
        }
    }
}