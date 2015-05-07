using System;
using System.Collections.Generic;

namespace GCUBankModel
{
    public class Account
    {
        protected decimal startingBalance;
 
        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        protected Dictionary<String,ITransaction> transactions;

        public Account(string accountNumber, decimal startingBalance)
        {
            this.accountNumber = accountNumber;
            this.startingBalance = startingBalance;
            transactions = new Dictionary<String,ITransaction>();
        }

        public void AddTransaction(ITransaction transaction)
        {
            string id;
            id = transaction.TransactionID;
            transactions.Add(id,transaction);
            
        }

        public ICollection<ITransaction> GetTransactions()
        {
            return transactions.Values;
        }

        public ITransaction GetTransaction(string transactionID)
        {
            return transactions[transactionID];
        }

        public virtual decimal GetBalance()
        {
            int c = transactions.Count;
            decimal bal = startingBalance;
            ITransaction value;
            List<string> keys = new List<string>(transactions.Keys);

            for (int i = 0; i > c; i++)
            {
            transactions.TryGetValue(keys[i], out value);
              bal += value.Amount;
            }

            return bal; 
        }

        public void CancelTransaction(string transactionID)
        {

            if (transactions.ContainsKey(transactionID))

            {
                GetTransaction(transactionID).Cancel();
            }
        }
           
    }
}
