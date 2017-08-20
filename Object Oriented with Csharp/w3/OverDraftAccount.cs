using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ToW5
{
    class OverDraftAccount : SavingsAccount
    {
        public OverDraftAccount(string AccountNumber, customer HolderName, double Balance) : base(AccountNumber, HolderName, Balance)
        {
        }

        public override double CalculateInterest()
        {
            if (balance > 0)
            {
                return balance * 0.25 / 100; // using protected to get the private balance 
            }
            else 
            {
                return balance * -6 / 100;
            }
        }

        public override bool Withdraw(double amount)
        {
            balance -= amount; //balance = balance - amount;
            return true;
        }



    }
}