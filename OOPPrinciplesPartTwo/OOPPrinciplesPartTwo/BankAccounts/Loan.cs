namespace OOPPrinciplesPartTwo.BankAccounts
{
    using System;
    public class Loan : Account, IDepositable
    {


        public Loan(CustomerType customerType, decimal balance, decimal interestRate)
            : base(customerType, balance, interestRate)
        {

        }

        public override decimal InterestAmount(int months)
        {
            decimal interestAmount = 0.00M;

            if (this.CustomerType == CustomerType.individual && months >= 3)
            {
                interestAmount = this.InterestRate / 100 * (months - 2);
            }
            else if (this.CustomerType == CustomerType.company && months >= 2)
            {
                interestAmount = this.InterestRate / 100 * (months - 2);
            }
            return interestAmount;
        }

        public void AddMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You cannot deposit a negative number !!");
            }
            if (this.Balance < amount)
            {
                Console.WriteLine("You have paid your loan !!");
                this.Balance = 0;
            }
            else
            {
                this.Balance -= amount;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
