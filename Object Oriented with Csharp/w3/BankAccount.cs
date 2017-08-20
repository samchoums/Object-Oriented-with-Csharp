using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ToW5
{

    //Ensure that you have appropriate accessibility specifiers for information hiding.
        class BankAccount   //////////////public?? then it can work in different namespace 
    {
        protected string account;
        protected customer holder;
        protected double balance;
       public BankAccount(string AccountNumber, customer HolderName, double Balance)
        {
            account = AccountNumber;
            holder = HolderName;
            balance = Balance;
        }
   

        //   3.1   Console.WriteLine("{0}---{1}",a.holderName,a.Account);  //error if you don't use property(get) in bankaccount class, can't read the attribute)
        public string Account
        {
            get
            {
                return account;
            }
        }

        public customer Holder
        {
            get
            {
                return holder;
            }
            set
            {
                holder = value;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
        }
        
        public virtual bool Withdraw(double amount)
        {
            if(amount < balance)
            {
                balance = balance - amount;
                return true;
            } else
            {
                Console.WriteLine("error");
                return false;  /////////////// outside?
            }       
        }
        public double deposit(double amount)  ///////////////////Can I use property? set? 
        {
            return balance = balance + amount;
        }

        public bool transferTo(double amount, BankAccount another)//////////////////////////
        {
            if(Withdraw(amount))
            {
                another.deposit(amount);
                return true;
            }else
            {
                Console.WriteLine("to {0} is unsuccessful", holder); //Console.Error.WriteLine
                return false;
            }
        }

        // form overDraftAccount
        public virtual double CalculateInterest()//////////////////////
        {
            return balance;
        }
        // from SavingsAccount
        public virtual double CreditInterest()
        {
            return deposit(CalculateInterest());
        }

        //public virtual void showAccount()
        //{
        //    // string m = string.Format(" accountNumber:{0},holderName:{1},balance:{2}",account, holder, balance); ////////////////
        //     Console.WriteLine(" accountNumber:{0},holderName:{1},balance:{2}",account, holder.Name, balance);
        //}

        public override string ToString() // using ToString method must return string, so use string m = string.Format
        {
            string m = string.Format(" accountNumber:{0},holderName:{1},balance:{2}", account, holder.Name, balance);                 
            return m;
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //    /*
        //        W3ToW5.SavingsAccount
        //        W3ToW5.OverDraftAccount
        //        W3ToW5.CurrentAccount
        //        W3ToW5.SavingsAccount
        //        */
        //}
    }
}
