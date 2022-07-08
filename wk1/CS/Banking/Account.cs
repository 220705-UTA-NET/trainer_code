using System;

namespace Banking
{
    class Account
    {
        // Fields / state
        // (access modifier) (type) (name) (initial value)
        protected double balance;

        public int accountNumber { get; set; }
        // {
        //     get
        //     {
        //         return accountNumber;
        //     }
            // set
            // {
            //     if (value == null)
            //     {
            //         throw new Exception(MessageProcessingHandler: "value cannot be null", paramName: nameof(ValueTask));
            //     }
            //     accountNumber = value;
            // }
        // }


        private string owner;

        private static int accountNumberSeed = 345667890;

        // Constructor - the set of instructions on how to create an object of this type.
        // (access modifier) (Class-name) (parameter list)

        public Account()
        {}

        public Account(double intialBalance, string owner)
        {
            this.accountNumber = accountNumberSeed;
            accountNumberSeed++;

            MakeDeposit(intialBalance);
            this.owner = owner;
        }


        // Methods / behavior
        // (access modifier) (return type) (name) (parameters)

        public void setAccountNumber(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public int getAccountNumber()
        {
            return accountNumber;
        }

        public string DisplayBalance()
        {
            string balanceString = balance.ToString();
            return balanceString;
        }

        public void MakeDeposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero");
            }
            else
            {
                balance += amount;
            }
        }

        public void makeWithdrawal(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero");
            }
            else if (balance - amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Insufficient funds");
            }
            else
            {
                balance -= amount;
            }
        }

    }
}