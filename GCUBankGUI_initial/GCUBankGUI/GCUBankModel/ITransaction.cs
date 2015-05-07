using System;


namespace GCUBankModel
{
    public interface ITransaction
    {
        string TransactionID { get; }

        decimal Amount { get; set;}

        void Cancel();

        //TODO: Add declarations for the following:
        //Amount – read/write property, type decimal
        //Date – read-only property, type DateTime
        //Cancel – method, return type void, no parameters

    }
}
