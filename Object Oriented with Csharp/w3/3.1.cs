using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop3;

namespace W3ToW5
{
    class Program
    {
        static void Main(string[] args)
        {
            customer ac = new customer("kevin", "51 street", "A123", new DateTime(1990, 11, 11));
            customer bc = new customer("Jay", "71 street", "V323", new DateTime(1978, 12, 31));
            Console.WriteLine(ac); // public override string ToString(), then it won't only show namespace and class(won't Returns a string that represents the current object.)
            Console.WriteLine(bc);
            //ac.showCustomer();
            //bc.showCustomer();
            Console.WriteLine("age ={0} ",bc.GetAge);

            BankAccount a = new BankAccount("a", ac, 20000);
            BankAccount b = new BankAccount("b", bc, 100);
            // Console.WriteLine("{0}---{1}",a.holderName,a.Account //error if you don't use property(get) in bankaccount class)
            // Console.WriteLine(a.holder);/////////////////////////  You should change attribute to public if you want to read the data


            //a.ToString();///////////////////////////
            a.deposit(200);
            Console.WriteLine(a);
            // a.showAccount();    
            b.Withdraw(10);
            Console.WriteLine(b);
            // b.showAccount();
            a.transferTo(20, b);
            // a.showAccount();
            Console.WriteLine(a);
            //b.showAccount();
            Console.WriteLine(b);

            a.Holder = new customer("jonh", "51 street", "A123", new DateTime(1980, 11, 11));////////////////////// change holder
            Console.WriteLine("change holder: {0}",a);
            // a.showAccount();


            // library 
            workshop3.Rational f = new workshop3.Rational(3, 4);
            workshop3.Rational g = new workshop3.Rational(4, 5);
            workshop3.Rational h = f.Add(g);
            Console.WriteLine(h.StrVal());
            h = g.Subtract(f);
            Console.WriteLine(h.StrVal());
            //

            SavingsAccount saving = new SavingsAccount("1", new customer("peter", "123", "666", new DateTime(1999, 5, 3)), 1000);
            Console.WriteLine(saving);
            //saving.showAccount();

            CurrentAccount current = new CurrentAccount("2", new customer("current", "222", "333", new DateTime(1993, 5, 6)), 100);
            Console.WriteLine(current);
            //current.showAccount();
  
            OverDraftAccount over = new OverDraftAccount("3", new customer("momo", "66", "77", new DateTime(1993, 3, 18)), 10);
            Console.WriteLine(over);
            //over.showAccount();

            over.Withdraw(15);
            Console.WriteLine(over);
            //over.showAccount();
            Console.WriteLine("show{0}",over.CalculateInterest());
            Console.WriteLine(over.CreditInterest());      
            Console.WriteLine(over);
            //over.showAccount();

            //bankBranch
            Console.WriteLine("bankBranch");
            BankBranch ocbc = new BankBranch("jurongEast", "sam");
            customer X = new customer("da", "eq", "23", new DateTime(1989, 3, 6));
            customer Y = new customer("ad", "hf", "12", new DateTime(1929, 7, 6));
            customer Z = new customer("qe", "ed", "13", new DateTime(1959, 3, 2));
            ocbc.AddAccount(new SavingsAccount("1", X, 200));
            ocbc.AddAccount(new OverDraftAccount("2", X, -100));
            ocbc.AddAccount(new CurrentAccount("3", Y, 300));
            ocbc.AddAccount(new SavingsAccount("4", Z, 2000));
            ocbc.PrintAccount();
            ocbc.PrintCustomers();
            Console.WriteLine(ocbc.TotalInterestPaid());
            Console.WriteLine(ocbc.TotalInterestEarned());
            ocbc.PrintAccount();

        }

    }
}
