﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Transaction
    {
        private double _sum;
        private DateTime _timeStamp;

        public Transaction(double sum, DateTime timeStamp)
        {
            _sum = sum;
            _timeStamp = timeStamp;
        }

        public double Sum { get => _sum; set => _sum = value; }
    }
}
