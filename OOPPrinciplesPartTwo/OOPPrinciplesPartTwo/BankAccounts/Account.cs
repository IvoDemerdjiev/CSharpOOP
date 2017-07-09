namespace OOPPrinciplesPartTwo.BankAccounts
{
    using System;

    public abstract class Account
    {

        private decimal balance;
        private decimal interestRate;
        private CustomerType customerType;

        public Account(CustomerType customerType, decimal balance, decimal interestRate)
        {
            this.CustomerType = customerType;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public CustomerType CustomerType { get; set; }

        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Bank Balance must be at least 0 !");
                }
                else
                {
                    this.balance = value;
                }
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Interest rate must be a positive number");
                }
                else
                {
                    this.interestRate = value;
                }
            }
        }


        public abstract decimal InterestAmount(int months);

        public override string ToString()
        {
            return string.Format("owner: {0}\n\rBalance: {1:C}\n\rInterest Rate: {2}%", this.CustomerType, this.Balance, this.InterestRate);
        }
    }
}