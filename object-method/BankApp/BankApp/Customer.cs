using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Customer
    {
        private string _accountNumber;
        private string _firstName;
        private string _lastName;

        public Customer(string accountNumber, string firstName, string lastName)
        {
            _accountNumber = accountNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}\t{_accountNumber}";
        }
    }
}
