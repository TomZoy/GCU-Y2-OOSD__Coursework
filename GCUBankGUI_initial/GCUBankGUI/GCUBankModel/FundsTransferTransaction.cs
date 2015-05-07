using System;

namespace GCUBankModel
{
    public class FundsTransferTransaction : ITransaction
    {
        private string transactionID;

        public string TransactionID
        {
            get { return transactionID; }
        }

        private decimal amount;

        private DateTime date;

        private string payeeSortCode;

        private string payeeAccount;


        //TODO:
        //Implement the properties declared in ITransaction - the appropriate instance variables are declared above, 
        //   so the properties should encapsulate these
        //Implement the Cancel method declared in ITransaction with a method which sets transaction amount 
        //  to -£1.00 (the bank charges for cancelling a funds transfer)
        //Add the following:
        //  PayeeSortCode – read-only property which encapsulates the instance variable payeeSortCode
        //  PayeeAccount – read-only property which encapsulates the instance variable payeeAccount
        //  Constructor which sets values of all instance variables
        //  (the amount instance variable should be set to the negative of the appropriate constructor parameter)
        //
        // NOTE that a Sort Code is a code which identifies the bank and branch of the account the funds are
        //  to be transferred to, and is of the form XX-XX-XX

        public override string ToString()
        {
            return String.Format("FT {0}:{1}  {2:c}  {3}:{4}",
                transactionID, date.ToShortDateString(), amount, payeeSortCode, payeeAccount);
        }

    }
}
