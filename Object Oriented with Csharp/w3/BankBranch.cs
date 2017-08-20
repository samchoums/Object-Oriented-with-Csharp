using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ToW5
{
    class BankBranch
    {
        string BranchName;
        string BranchManager;
        //ArrayList BankAccounts; //using System.Collections; 
        List<BankAccount> BankAccounts; // only same data type can input 
        //the ArrayList class that is empty and has the default initial capacity. You don't need to use constructor to input the value 
        public BankBranch(string BranchName, string BranchManager)
        {
            this.BranchName = BranchName;
            this.BranchManager = BranchManager;
            //BankAccounts = new ArrayList();
            BankAccounts = new List<BankAccount>();
        }

        public string Name()
        {
            return BranchName;
        }

        public string Manager()
        {
            return BranchManager;
        }

        public void AddAccount(BankAccount a)
        {
            BankAccounts.Add(a);
        }

        public void PrintAccount()
        {
            for (int i = 0; i < BankAccounts.Count; i++)     //
            {
                //BankAccount a = (BankAccount)BankAccounts[i];//////////////////
                //a.showAccount();
                Console.WriteLine(BankAccounts[i]);    // tostring method 
            }
        }

        public void PrintCustomers() //////////////
        {  
            for (int i = 0; i < BankAccounts.Count; i++)
            {
                /* BankAccount a = (BankAccount)BankAccounts[i];///*/////////////// ArrayList BankAccounts;
                BankAccount a =  BankAccounts[i];   // list, same data type 
                customer c = a.Holder;
                Console.WriteLine(c);
              //  c.showCustomer();
            }
        }

        public double TotalDeposits()       ///////////// Saving or currentAccount?
        {
            double total = 0;
            for (int i = 0; i < BankAccounts.Count; i++)
            {
                //BankAccount a = (BankAccount)BankAccounts[i];
                BankAccount a = BankAccounts[i];
                total += a.Balance;
            }
            return total;
        }
       
        public double TotalInterestPaid()
        {
            double total = 0;
            for (int i = 0; i < BankAccounts.Count; i++)
            {
                //BankAccount a = (BankAccount)BankAccounts[i];///////////////////////
                BankAccount a = BankAccounts[i];
                if (a.CalculateInterest()<0)
                {
                    total += a.CalculateInterest();
                }                    
            }
            return total;
        }

        public double TotalInterestEarned()
        {
            double total = 0;
            for (int i = 0; i < BankAccounts.Count; i++)
            {
                BankAccount a = BankAccounts[i];///////////////////////
                    total += a.CreditInterest();
            }
            return total;
        }
    }
}












