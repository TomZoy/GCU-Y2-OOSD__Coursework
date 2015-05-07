using System;
using System.Collections.Generic;

namespace GCUBankModel
{
    public class SavingsAccount : Account
    {
        private decimal interestRate;

        public decimal InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        private decimal accruedInterest;

        public SavingsAccount(string accountNumber, decimal startingBalance, decimal interestRate) :
            base(accountNumber, startingBalance)
        {
            this.interestRate = interestRate;
        }

        public override decimal GetBalance()  
        {
            int c = transactions.Count;
            decimal bal = startingBalance + accruedInterest;
            ITransaction value;
            List<string> keys = new List<string>(transactions.Keys);

            for (int i = 0; i > c; i++)
            {
                transactions.TryGetValue(keys[i], out value);
                bal += value.Amount;
            }

            return bal; 
        }

        public void AddInterest()
        {
            decimal interest = interestRate / 100 * GetBalance();
            accruedInterest = accruedInterest + interest;
        }
    }
}
