namespace OOPPrinciplesPartTwo.BankAccounts
{
    using System;

    class Mortgage : Account, IDepositable
    {
        public Mortgage(CustomerType customerType, decimal bankBalance, decimal interestRate)
            : base(customerType, bankBalance, interestRate)
        {

        }

        public void AddMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You cannot deposit a negative number !!");
            }
            if (this.Balance < amount)
            {
                Console.WriteLine("You have paid your mortgage !!");
                this.Balance = 0;
            }
            else
            {
                this.Balance -= amount;
            }
        }

        public override decimal InterestAmount(int months)
        {
            decimal interestAmount = 0.00m;

            if (this.CustomerType == CustomerType.individual && months > 6)
            {
                interestAmount = this.InterestRate / 100 * (months - 6);
            }
            else if (this.CustomerType == CustomerType.company && months <= 12)
            {
                interestAmount = (this.InterestRate / 100 * months) / 2;
            }
            else if (this.CustomerType == CustomerType.company && months > 12)
            {
                interestAmount = this.InterestRate / 100 * (months - 12) + (this.InterestRate / 100 * 12) / 2;
            }
            return interestAmount;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
