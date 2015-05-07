using System;

namespace GCUBankModel
{
    public class WithdrawalTransaction : ITransaction
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
        //  (the  instance variable encapsulated by the Amount property should be set to the negative 
        //   of the appropriate constructor parameter)
        //  ToString method which returns a formatted string containing all property values (see 
        //  FundsTransferTransaction for an example)


    }
}
