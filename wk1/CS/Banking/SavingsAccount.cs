namespace Banking
{
    class SavingsAccount : Account // the " : Account" means we are EXTENDING the Account class.
    // The SavingsAccout type is an Account type
    {
        // Fields / state
        private double interestRate; 

        // Constructor
        // public SavingsAccount(string owner, double initialBalance) : base(initialBalance, owner)
        // {
        //     this.interestRate = 0.0003;
        // }
        // public SavingsAccount(string owner, double initialBalance, double interestRate) : base(initialBalance, owner)
        // {
        //     this.interestRate = interestRate;
        // }
        public SavingsAccount(string owner, double initialBalance, double interestRate = 0.0003) : base(initialBalance, owner)
        {
            this.interestRate = interestRate;
        }


        // Methods / behavior
        public void ApplyInterest()
        {
            double payment = this.balance * this.interestRate;
            this.MakeDeposit(payment);
        }
    }
}
