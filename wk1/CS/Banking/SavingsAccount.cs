namespace Banking
{
    class SavingsAccount : Account // the " : Account" means we are EXTENDING the Account class.
    // The SavingsAccout type is an Account type
    {
        // Fields / state
        private double interestRate; 

        // Constructor

        // Methods / behavior

        public void ApplyInterest()
        {
            double payment = this.balance * this.interestRate;
            this.MakeDeposit(payment);
        }
    }
}
