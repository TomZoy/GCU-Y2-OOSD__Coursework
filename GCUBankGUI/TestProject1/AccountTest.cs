using GCUBankModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for AccountTest and is intended
    ///to contain all AccountTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AccountTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CancelTransaction
        ///</summary>
        [TestMethod()]
        public void CancelTransactionTest()
        {
            //ARRANGE
            string accountNumber = "88448844";//string.Empty; // TODO: Initialize to an appropriate value
            Decimal startingBalance = 1000.00m;//new Decimal(); // TODO: Initialize to an appropriate value
            Account target = new Account(accountNumber, startingBalance); // TODO: Initialize to an appropriate value
            FundsTransferTransaction ftt8 = new FundsTransferTransaction("T8", DateTime.Now, -200.00m, null, null);
            //FundsTransferTransaction ftt2 = new FundsTransferTransaction("T002", DateTime.Now, 200, null, null);

            //ACT
            target.AddTransaction(ftt8);
         //   target.AddTransaction(ftt2);
            target.CancelTransaction("T8");

            //ASSERT
            Decimal actual;
            actual = target.GetBalance();

            Assert.AreEqual(actual, startingBalance-1);
        }

        /// <summary>
        ///A test for GetBalance
        ///</summary>
        [TestMethod()]
        public void GetBalanceTest()
        {
            string accountNumber = "88448844"; //string.Empty; // TODO: Initialize to an appropriate value
            Decimal startingBalance = 1000.00m;//new Decimal(); // TODO: Initialize to an appropriate value
            Account target = new Account(accountNumber, startingBalance); // TODO: Initialize to an appropriate value
           
            Decimal expected = 1000.00m; // TODO: Initialize to an appropriate value
            Decimal actual;
            
            actual = target.GetBalance();
           
            Assert.AreEqual(expected, actual);

        }
    }
}
