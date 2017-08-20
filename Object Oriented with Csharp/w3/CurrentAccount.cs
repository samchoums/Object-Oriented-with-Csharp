using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ToW5
{
    class CurrentAccount: SavingsAccount
    {
        public CurrentAccount(string AccountNumber, customer HolderName, double Balance) : base(AccountNumber, HolderName, Balance)
        {
        }

        public override double CalculateInterest()
        {
            return balance * 0.25 / 100; // using protected to get the private balance 
        }
    }
}
