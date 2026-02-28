using System;
using static System.Console;

namespace BankingSystem
{
    public abstract class Account
    {
        public string AccountHolderName;
        public double Balance;

        public Account(string name , Double balance) 
        {
            AccountHolderName = name;
            Balance = balance;  
        }

        public abstract double CalculateIntrest();
    }

    public class SavingsAccount : Account
    {
        public SavingsAccount(string name, Double Balance) : base(name, Balance) {}

        public override double CalculateIntrest()
        {
            return Balance * 0.05;
        }
    }

    public class CurrentAccount : Account 
    {
    
        public CurrentAccount (string name, double Balance) : base(name, Balance) {}

        public override double CalculateIntrest() 
        {
            return Balance * 0.02;
        }
    }


//*****************************************************
    class Project
    {
        static void Main()
        {

            WriteLine("-----Hello , This is The Banking System-----");
            WriteLine("=====================================================");


            List<Account> acc1 = new List<Account>
            {
            new SavingsAccount("Moh" , 10000),
            new CurrentAccount("Ahmed" , 5000)
            };

            foreach(var Account in acc1)
            {
                WriteLine($"Name: {Account.AccountHolderName}  ");
                WriteLine($"Balance:{Account.Balance} ");
                WriteLine($"This is {Account.GetType().Name} Intrest :{ Account.CalculateIntrest() } \n");
            }

        //======================================================================================================//
            
            
            ReadKey();
        }
    }
}