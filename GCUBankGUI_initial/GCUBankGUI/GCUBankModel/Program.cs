//#define TEST_TRANSACTIONS
//#define TEST_ACCOUNTS

using System;
using System.Collections.Generic;


namespace GCUBankModel
{
    class Program
    {
        static void Main(string[] args)
        {
            // TESTING TRANSACTION CLASSES   
            // SHOULD GIVE THE FOLLOWING OUTPUT 
            // *****************************************************
                //TRANSACTION TEST:
                //FT T002:10/09/2013  -£200.00  99-99-00:990011
                //WD T003:10/09/2013  -£50.00  88-88-00
                //CR T005:10/09/2013  £200.00  88-88-00
                //Cancelled - FT T002:10/09/2013  -£1.00  99-99-00:990011
                //Cancelled - WD T003:10/09/2013  £0.00  88-88-00
            // *****************************************************
#if TEST_TRANSACTIONS
            FundsTransferTransaction ftt = new FundsTransferTransaction("T002", DateTime.Now, 200.00m, "99-99-00", "990011");
            WithdrawalTransaction wdt = new WithdrawalTransaction("T003", DateTime.Now, 50.00m, "88-88-00"); 
            CreditTransaction crt = new CreditTransaction("T005", DateTime.Now, 200.00m, "88-88-00");
            Console.WriteLine("TRANSACTION TEST:");
            Console.WriteLine(ftt.ToString());
            Console.WriteLine(wdt.ToString());
            Console.WriteLine(crt.ToString());
            ftt.Cancel();
            wdt.Cancel();
            Console.WriteLine("Cancelled - {0}",ftt.ToString());
            Console.WriteLine("Cancelled - {0}", wdt.ToString());
            Console.WriteLine();
#endif

            // TESTING ACCOUNT CLASSES   
            // SHOULD GIVE THE FOLLOWING OUTPUT 
            // *****************************************************
                //ACCOUNT TEST:
                //Account Balance=£250.00
                //SavingsAccount Balance=£275.00
                //Cancelled Transaction - Account Balance=£349.00
                //Cancelled Transaction - SavingsAccount Balance=£350.00
                //Cancelled Non-existent Transaction - SavingsAccount Balance=£350.00
                //Added Interest - SavingsAccount Balance=£385.00
                //Account transactions:
                //FT T001:11/09/2013  -£1.00  99-99-00:990011
                //WD T003:11/09/2013  -£50.00  88-88-00
                //CR T005:11/09/2013  £200.00  88-88-02
                //SavingsAccount transactions:
                //FT T002:11/09/2013  -£200.00  44-44-00:440011
                //WD T004:11/09/2013  £0.00  88-88-01
                //CR T006:11/09/2013  £50.00  88-88-03
            // *****************************************************
#if TEST_ACCOUNTS
            Account acc = new Account("ACC001", 200.0m);
            SavingsAccount sacc = new SavingsAccount("ACC002", 500.0m, 10.0m);
            FundsTransferTransaction ftt1 = new FundsTransferTransaction("T001", DateTime.Now, 100.00m, "99-99-00", "990011");
            FundsTransferTransaction ftt2 = new FundsTransferTransaction("T002", DateTime.Now, 200.00m, "44-44-00", "440011");
            WithdrawalTransaction wdt1 = new WithdrawalTransaction("T003", DateTime.Now, 50.00m, "88-88-00");
            WithdrawalTransaction wdt2 = new WithdrawalTransaction("T004", DateTime.Now, 75.00m, "88-88-01");
            CreditTransaction crt1 = new CreditTransaction("T005", DateTime.Now, 200.00m, "88-88-02");
            CreditTransaction crt2 = new CreditTransaction("T006", DateTime.Now, 50.00m, "88-88-03");
            acc.AddTransaction(ftt1);
            sacc.AddTransaction(ftt2);
            acc.AddTransaction(wdt1);
            sacc.AddTransaction(wdt2);
            acc.AddTransaction(crt1);
            sacc.AddTransaction(crt2);

            Console.WriteLine("ACCOUNT TEST:");
            Console.WriteLine("Account Balance={0:c}", acc.GetBalance());
            Console.WriteLine("SavingsAccount Balance={0:c}", sacc.GetBalance());

            acc.CancelTransaction("T001");
            Console.WriteLine("Cancelled Transaction - Account Balance={0:c}", acc.GetBalance());

            sacc.CancelTransaction("T004");
            Console.WriteLine("Cancelled Transaction - SavingsAccount Balance={0:c}", sacc.GetBalance());

            sacc.CancelTransaction("TXXX");
            Console.WriteLine("Cancelled Non-existent Transaction - SavingsAccount Balance={0:c}", sacc.GetBalance());

            sacc.AddInterest();
            Console.WriteLine("Added Interest - SavingsAccount Balance={0:c}", sacc.GetBalance());

            Console.WriteLine("Account transactions:");
            ICollection<ITransaction> transactions = acc.GetTransactions();
            foreach (ITransaction tr in transactions)
            {
                Console.WriteLine(tr.ToString());
            }

            Console.WriteLine("SavingsAccount transactions:");
            transactions = sacc.GetTransactions();
            foreach (ITransaction tr in transactions)
            {
                Console.WriteLine(tr.ToString());
            }
            Console.WriteLine();
#endif
        
            Console.ReadLine();

        }
    }
}
