using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Account newAccount = new Account(1000, "Eunice");
            Account secondAccount = new SavingsAccount("James", 500);
            Account thirdAccount = new Account(100, "John");

            // Console.WriteLine(newAccount.accountNumber.ToString());
            // Console.WriteLine(secondAccount.accountNumber.ToString());
            // Console.WriteLine(thirdAccount.accountNumber.ToString());


            // thirdAccount.accountNumber = 12345;
            // Console.WriteLine(thirdAccount.accountNumber.ToString());
  

            secondAccount.MakeDeposit(150, "Got Paid");
            secondAccount.MakeDeposit(50, "dinner with friends");
            secondAccount.makeWithdrawal(75, "New Game");
            secondAccount.makeWithdrawal(25, "Lunch");

            // string Transactions = secondAccount.getAccountHistory();
            // Console.WriteLine(Transactions);
            Console.WriteLine(secondAccount.getAccountHistory());


  
  
  
  
  
  
  
  
  
  
            // try
            // {
            // newAccount.MakeDeposit(100);
            // Console.WriteLine(newAccount.DisplayBalance());
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }

            // try
            // {
            //     newAccount.makeWithdrawal(50);
            //     Console.WriteLine(newAccount.DisplayBalance());
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }
                        
            // try
            // {
            //     newAccount.makeWithdrawal(51);
            //     Console.WriteLine(newAccount.DisplayBalance());
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }

            // try
            // {
            //     newAccount.makeWithdrawal(-50);
            //     Console.WriteLine(newAccount.DisplayBalance());
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }
        }
    }
}