using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testy_Account;

namespace Tests
{
    [TestClass]
    public class AccountServiceTests
    {
        [TestMethod]
        public void AddingTransactionToAccountDelegateToAccountInstance()
        {
            var account = new Account();

            var fakeRepository = new FakeAccountRepository(account);

            var sut = new AccountService(fakeRepository);

            sut.AddTransactionToAccount("Konto firmowe",200m);

        }




    }
}
