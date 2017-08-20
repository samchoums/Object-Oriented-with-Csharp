using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop3;

namespace W3ToW5
{

    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string AccountNumber, customer HolderName, double Balance) : base(AccountNumber, HolderName, Balance)
        {
        }

        public override double CalculateInterest()
        {
                return balance * 1 / 100; // using protected to get the private balance 
      
        }

        public override double CreditInterest()
        {
                return deposit(CalculateInterest());
        }

        //public override void showAccount()   // new will use parent's method instead of child's method if you assign parent to child. so you should use override.
        //{
        //    //Console.WriteLine(" accountNumber:{0},holderName:{1},balance:{2}, CalculateInterest:{3},CreditInterest:{4}", account, holder.Name, balance, CalculateInterest(), CreditInterest());
        //    Console.WriteLine(" accountNumber:{0},holderName:{1},balance:{2}", account, holder.Name, balance);
        //}

    }

}
