using System;


namespace GCUBankModel
{
    public class CreditTransaction : ITransaction
    {
        private string transactionID;

        public string TransactionID
        {
            get { return transactionID; }
        }

        //TODO:
        //Implement the properties declared in ITransaction, along with appropriate instance variables
        //Implement the Cancel method declared in ITransaction with a method which sets transaction amount to zero
        //Add the following:
        //  BranchID – read-only string property, along with appropriate instance variable
        //  Constructor which sets values of all instance variables
        //  ToString method which returns a formatted string containing all property values (see 
        //  FundsTransferTransaction for an example)

    }
}
