namespace Banking
{
    class Account
    {
        // Fields / state
        // (access modifier) (type) (name) (initial value)
        protected double balance;
        private List<Transaction> transactions = new List<Transaction>();
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

        public void MakeDeposit(double amount, string note = "")
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero");
            }
            else
            {
                balance += amount;
                var deposit = new Transaction(amount, DateTime.Now, note);
                transactions.Add(deposit);
            }
        }

        public void makeWithdrawal(double amount, string note = "")
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
                var withdrawl = new Transaction(amount, DateTime.Now, note);
                transactions.Add(withdrawl);
            }
        }

        public string getAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            report.AppendLine("Date\t\tAmount\t\tNote");
            foreach(var item in transactions)
            {
                report.AppendLine($"{item.date.ToShortDateString()}\t{item.amount}\t{item.note}");
            }
            return report.ToString();
        }

    }
}