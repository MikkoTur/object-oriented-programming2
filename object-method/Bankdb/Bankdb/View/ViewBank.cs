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

        public void PrintCustomer()
        {
            var customers = customerRepository.GetCustomers();
            foreach (var c in customers)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
