using System;


namespace GCUBankModel
{

    /// <summary>
    /// definies an interface, which can be used to make sure all transaction classes have a common ground
    /// </summary>
    /// <param name="TransactionID">the identifier of the transaction</param>
    /// <param name="Amount">the amount of the transaction</param>
    /// <param name="Date">the date of the transaction</param>

    public interface ITransaction
    {

        string TransactionID { get; }
        decimal Amount { get; set; }
        DateTime Date { get; set; }

        /// <summary>
        /// deffines a method that can be used to cancel a transaction. (the actual class definies how)
        /// </summary>
        void Cancel();

        //+TODO: Add declarations for the following:
        //+Amount – read/write property, type decimal
        //+Date – read-only property, type DateTime
        //+Cancel – method, return type void, no parameters





    }
}
