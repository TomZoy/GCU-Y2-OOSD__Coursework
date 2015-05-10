using System;

namespace GCUBankModel
{
    public class FundsTransferTransaction : ITransaction
    {

        //Interface variables

        /// <summary>
        /// this class represents a specific type of transactions; fund transfer transactions. It uses ITransaction interface.
        /// </summary>
        /// <param name="TransactionID">the unique identifier of the transaction</param>
        /// <param name="Amount">the amount of the transaction</param>
        /// <param name="Date">the date when the transaction was made</param>
        /// <param name="PayeeSortCode">the short-code of the payee</param>
        /// <param name="PayeeAccount">the account number of the payee</param>


        
        private string transactionID;
        public string TransactionID
        {
            get { return transactionID; }
        }

        private decimal amount;
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        //class-specific variables
        private string payeeSortCode;
        public string PayeeSortCode
        {
            get { return payeeSortCode; }

        }

        private string payeeAccount;
        public string PayeeAccount
        {
            get { return payeeAccount; }

        }

        //Interface methods:

        /// <summary>
        /// cancels the transaction by making its ammount -1
        /// </summary>
        public void Cancel()
        {
            this.Amount = -1;
        }

        //TODO:
        //+Implement the properties declared in ITransaction - the appropriate instance variables are declared above, 
        //+so the properties should encapsulate these
        //+Implement the Cancel method declared in ITransaction with a method which sets transaction amount to -£1.00 (the bank charges for cancelling a funds transfer)
        //+Add the following:
        // + PayeeSortCode – read-only property which encapsulates the instance variable payeeSortCode
        // + PayeeAccount – read-only property which encapsulates the instance variable payeeAccount
        // + Constructor which sets values of all instance variables
        // + (the amount instance variable should be set to the negative of the appropriate constructor parameter)
        //
        // + NOTE that a Sort Code is a code which identifies the bank and branch of the account the funds are
        // + to be transferred to, and is of the form XX-XX-XX



        /// <summary>
        /// transcodes the transaction object's properties into a single line of string
        /// </summary>
        /// <returns>string representation of the transaftion object</returns>
        public override string ToString()
        {
            return String.Format("FT {0}:{1}  {2:c}  {3}:{4}",
                transactionID, date.ToShortDateString(), amount, payeeSortCode, payeeAccount);
        }


        //constructor

        /// <summary>
        /// creates a new fund transfer transaction with the given parameters
        /// </summary>
        /// <param name="trID">the identifier of the transaction to be created</param>
        /// <param name="dat">the date when the transaction was made</param>
        /// <param name="am">the amount of the transaction</param>
        /// <param name="psc">the payee short code</param>
        /// <param name="pacc">the payee account number</param>
        public FundsTransferTransaction(string trID, DateTime dat, decimal am, string psc, string pacc)
        {
            this.transactionID = trID;
            this.amount = -am;
            this.date = dat;
            this.payeeSortCode = psc;
            this.payeeAccount = pacc;
        }


    }
}
