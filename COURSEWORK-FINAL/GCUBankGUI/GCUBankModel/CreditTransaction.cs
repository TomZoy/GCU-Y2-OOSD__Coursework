using System;


namespace GCUBankModel
{

    /// <summary>
    /// this class represents a specific type of transactions; credit transactions. It uses ITransaction interface.
    /// </summary>
    /// <param name="TransactionID">the unique identifier of the transaction</param>
    /// <param name="Amount">the amount of the transaction</param>
    /// <param name="Date">the date when the transaction was made</param>
    /// <param name="BranchID">the indentifier of the branch</param>
    public class CreditTransaction : ITransaction
    {

        // Interface variables:
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

        //Interface methods:



       /// <summary>
       /// cancels the transaction by making its ammount 0
       /// </summary>
        public void Cancel()
        {
            this.Amount = 0;        
        }

        //Addigional variables
        private String branchID;


        public String BranchID
        {
            get { return branchID; }

        }
        //constructor

        /// <summary>
        /// creates a new credit transaction with the given parameters
        /// </summary>
        /// <param name="transID">the identifier of the transaction to be created</param>
        /// <param name="dt">the date when the transaction was made</param>
        /// <param name="am">the amount of the transaction</param>
        /// <param name="branchID">the indentifier of the branch</param>
        public CreditTransaction(string transID, DateTime dt, decimal am, string branchID)
        {
            this.transactionID = transID;
            this.Amount = am;
            this.Date = dt;
            this.branchID = branchID;
        
        }

        /// <summary>
        /// transcodes the transaction object's properties into a single line of string
        /// </summary>
        /// <returns>string representation of the transaftion object</returns>
        public override string ToString()
        {
            return String.Format("CR {0}:{1}  {2:c}  {3}",
                TransactionID, Date.ToShortDateString(), Amount, BranchID);
        
        
        }

        //TODO:
        //+Implement the properties declared in ITransaction, along with appropriate instance variables
        //+Implement the Cancel method declared in ITransaction with a method which sets transaction amount to zero
        //+Add the following:
        //  +BranchID – read-only string property, along with appropriate instance variable
        //  +Constructor which sets values of all instance variables
        //  +ToString method which returns a formatted string containing all property values (see 
        //  +FundsTransferTransaction for an example)

    }
}
