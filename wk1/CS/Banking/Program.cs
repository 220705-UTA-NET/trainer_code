using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Account newAccount = new Account(1000, "Eunice");
            Account secondAccount = new Account(500, "James");
            Account thirdAccount = new Account(100, "John");

            Console.WriteLine(newAccount.accountNumber.ToString());
            Console.WriteLine(secondAccount.accountNumber.ToString());
            Console.WriteLine(thirdAccount.accountNumber.ToString());


            thirdAccount.accountNumber = 12345;
            Console.WriteLine(thirdAccount.accountNumber.ToString());
  
  
  
  
  
  
  
  
  
  
  
  
  
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