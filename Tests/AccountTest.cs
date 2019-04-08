using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testy_Account;

namespace Tests
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void AddingTransactionChangesBalance()
        {
            var account = new Account();
            account.AddTransaction(200m);

            Assert.AreEqual(200m, account.Balance);
        }

        [TestMethod]
        public void AccountsHaveAnOpeningBalanceOfZero()
        {
            var account = new Account();
            
            Assert.AreEqual(0m, account.Balance);
        }
        [TestMethod]
        public void AddingTransactionChangesBalance100()
        {
            var account = new Account();
            account.AddTransaction(100m);


            Assert.AreEqual(100m, account.Balance);
        }

        [TestMethod]
        public void AddingTwoTransactionsCreatesSummationBalance()
        {
            var account = new Account();
            account.AddTransaction(100m);
            account.AddTransaction(150m);

            Assert.AreEqual(250m, account.Balance);
        }


    }
}
