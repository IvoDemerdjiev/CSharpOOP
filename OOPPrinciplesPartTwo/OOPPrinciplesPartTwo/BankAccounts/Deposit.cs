namespace OOPPrinciplesPartTwo.BankAccounts
{
    using System;

   public class Deposit : Account, IDepositable, IWithdrawable
    {
        public Deposit(CustomerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal InterestAmount(int months)
        {
            decimal interestAmount = 0;
            if (this.Balance < 1000)
            {
                Console.WriteLine("Bank balance must be larger than {0:C} to count Interest Amount. Your balance is: {1:C}", 1000, this.Balance);
            }
            else
            {
                interestAmount = (this.InterestRate / 100 * months);
            }
            return interestAmount;
        }

        public void AddMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public void WithdrawMoney(decimal amount)
        {
            if (this.Balance < amount)
            {
                Console.WriteLine("Not enough money to withdraw. Your balance is: {0:C}", this.Balance);
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