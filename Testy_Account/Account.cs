using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy_Account
{
   public class Account
    {

        public void AddTransaction(decimal amount)
        {
            Balance += amount;

        }

        public decimal Balance { get; private set; }

    }
}
