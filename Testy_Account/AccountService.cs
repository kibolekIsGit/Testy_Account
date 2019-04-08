using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy_Account
{
    public class AccountService : IAccountService
    {
        //public AccountService(IAccountRepository repository)
        //{
        //    this.repository = repository;
        //}

        public void AddTransactionToAccount(string uniqueAccountName, decimal transactionAmount)
        {
            var account = repository.GetByName(uniqueAccountName);
            account.AddTransaction(transactionAmount);
        }
        private readonly IAccountRepository repository;
     

        public AccountService(IAccountRepository repository)
        {
            this.repository = repository;
        }
    }
}
