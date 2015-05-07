using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GCUBankModel
{

    /// <summary>
    /// this class represents the accounts in the system. Entities can have transactions assosiated with them.
    /// </summary>
    /// <param name="startingBalance">the balance of the account when created</param>
    /// <param name="accountNumber">the unique identifier of the account</param>
    /// <param name="transactions">the set of the assosiated transactions</param>
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

        /// <summary>
        /// creates a new account with the given parameters and a list to store assinged transactions
        /// </summary>
        /// <param name="accountNumber">the identifier of the account to be created</param>
        /// <param name="startingBalance">the initial balance of the account to be created</param>
        public Account(string accountNumber, decimal startingBalance)
        {
            this.accountNumber = accountNumber;
            this.startingBalance = startingBalance;
            transactions = new Dictionary<String,ITransaction>();
        }




        /// <summary>
        /// adds the specified transaction to the account
        /// throws DebitException if the transaction's ammount would take the account to negative balance
        /// throws DebitException if the transaction type is withdrawal and the ammount is more than 350
        /// </summary>
        /// <param name="transaction"> the transaction to be added</param>
        public void AddTransaction(ITransaction transaction)
        {


            /* -- MY FIRST SOLUTION --

            string trasnferType;

            //see if the type is Credit or not     
            if (transaction.Amount > 0)
            {
                trasnferType="credit";
            }
            
            //see if the type is Fundtransfer, ot not
            else if (transaction.GetType().GetProperty("PayeeAccount") != null)
            {
                trasnferType = "fund";
            }
            //the only type left is Withdrawal
            else
            {
                   trasnferType = "wdraw";
            }


            //TODO part3: If the transaction is a debit (withdrawal or funds transfer) and the resulting balance would be negative  

            if ((trasnferType == "wdraw" || trasnferType == "fund") && ((GetBalance() + transaction.Amount) < 0))
            {
               // Debug.WriteLine("HEY Dude! out of money!");
               // Debug.WriteLine(GetBalance() + transaction.Amount);
                throw new DebitException(transaction.Amount);
                //return; not needed, as exception throw exits the method as well
            }

            //TODO part3: If the transaction is a withdrawal and the specified amount is > £350
            if ((trasnferType=="wdraw") && transaction.Amount < -350)
            {
               // Debug.WriteLine("negative ammount is more than 350! + WD");
                throw new DebitException(transaction.Amount);
                //return; not needed, as exception throw exits the method as well
            }

            
            */

            /* SECOND SOLUTION*/


            //its amount is negative in both events
            if ((transaction.Amount < 0) && (GetBalance() + transaction.Amount < 0))
            {
                throw new DebitException(transaction.Amount);
            }

            //getting the type method
            if ((transaction.GetType() == typeof(WithdrawalTransaction)) && (transaction.Amount < -350))
            {
                // Debug.WriteLine("negative ammount is more than 350! + WD");
                throw new DebitException(transaction.Amount);
                //return; not needed, as exception throw exits the method as well
            }



            //TODO part2: implement code which adds the transaction object to the transactions collection
            transactions.Add(transaction.TransactionID,transaction);
            
        }





        /// <summary>
        /// returns a collection of transactions
        /// </summary>
        /// <returns>collection of transactions</returns>
        public ICollection<ITransaction> GetTransactions()
        {
            return transactions.Values;
        }

        /// <summary>
        /// returns a specific transaction identified by the given parameter
        /// </summary>
        /// <param name="transactionID">identifier of the transaction</param>
        /// <returns>returns the transaction</returns>
        public ITransaction GetTransaction(string transactionID)
        {
            return transactions[transactionID];
        }


        /// <summary>
        /// returns the current balance of the account
        /// </summary>
        /// <returns>the balance of the account</returns>
        /// 
        public virtual decimal GetBalance()    //TODO: modify the method declaration so that it can be overridden by a derived class
        {
            //TODO: implement code which calculates the balance by adding up the
            //amounts of all transactions and adding to the starting balance

            decimal balance = this.startingBalance;

            foreach (var dic in transactions)
            {
                balance += dic.Value.Amount;
            }


            return balance;
        }

        /// <summary>
        /// calls the cancel method of the transaction identifyed by the given parameter
        /// </summary>
        /// <param name="transactionID">the identifier of the transaction to be cancelled</param>
        public void CancelTransaction(string transactionID)
        {
            //TODO: implement code which cancels the transaction
            //with the given transactionID - if there is no transaction
            //with that transactionID no action should be taken, but you
            //should make sure that no exception is thrown in that case

            ITransaction obj;

            if(transactions.ContainsKey(transactionID))
            {

                obj = GetTransaction(transactionID);
                obj.Cancel();
            }
            else
            {
                return;
            }



        }
           
    }
}
