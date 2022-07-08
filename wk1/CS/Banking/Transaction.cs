namespace Banking
{
    class Transaction
    {
        // Fields / state
        public double amount;
        public string note;
        public DateTime date;
        public int transId;

        private static int transactionIdSeed = 123456789;

        
        // Constructor
        public Transaction(double amount, DateTime date, string note)
        {
            this.amount = amount;
            this.date = date;
            this.note = note;
            this.transId = transactionIdSeed;
            transactionIdSeed++;
        }

        // Methods / behavior
    }
}