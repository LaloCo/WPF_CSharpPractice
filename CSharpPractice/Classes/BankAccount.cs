﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice.Classes
{
    public class BankAccount
    {
        private double balance;
        public double Balance
        {
            get
            {
                if (balance < 1000000)
                    return balance;
                return 1000000;
            }
            set
            {
                if (value > 0)
                    balance = value;
                else
                    balance = 0;
            }
        }

        public double AddToBalance(double balanceToBeAdded)
        {
            Balance += balanceToBeAdded;
            return Balance;
        }
    }
}