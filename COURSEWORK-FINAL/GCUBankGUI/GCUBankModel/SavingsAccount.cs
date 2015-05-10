using System;
using System.Collections.Generic;

namespace GCUBankModel
{

    /// <summary>
    /// this class represents a specific subtype of accounts in the system. Entities can have transactions assosiated with them.
    /// </summary>
    /// <param name="InterestRate">the intrest rate for the account</param>
    /// <param name="accountNumber">the unique identifier of the account</param>
    /// <param name="transactions">the set of the assosiated transactions</param>
    public class SavingsAccount : Account
    {
        private decimal interestRate;

        public decimal InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        private decimal accruedInterest;

        //constructor

        /// <summary>
        /// creates a new savings account with the given parameters and a list to store assinged transactions
        /// </summary>
        /// <param name="accountNumber">the identifier of the account to be created</param>
        /// <param name="startingBalance">the initial balance of the account to be created</param>
        /// <param name="interestRate">the initial intrest rate of the account</param>
        public SavingsAccount(string accountNumber, decimal startingBalance, decimal interestRate) :
            base(accountNumber, startingBalance)
        {
            this.interestRate = interestRate;
        }


        /// <summary>
        /// returns the current balance of the account
        /// </summary>
        /// <returns>the balance of the account</returns>
        /// 
        public override decimal GetBalance()   //TODO: modify the method declaration so that it overrides the base class method
        {
            //TODO: implement code which calculates the balance by adding up the
            //amounts of all transactions and the accrued interest and adding these to the starting balance 

            decimal balance = this.startingBalance + this.accruedInterest;

            foreach (var dic in transactions)
            {
                balance += dic.Value.Amount;
            }


            return balance;
        }


        /// <summary>
        /// calculates the interest on the current balance and adds it to accruedInterest.
        /// </summary>
        /// 
        public void AddInterest()
        {
            // TODO: implement code which calculates the interest on the current balance
            // and adds it to accruedInterest. The interestRate value is the percentage interest rate, so the
            // interest to be added is an amount based on the current balance and that percentage

            this.accruedInterest += GetBalance() * (interestRate/100);
            
        }
    }
}
