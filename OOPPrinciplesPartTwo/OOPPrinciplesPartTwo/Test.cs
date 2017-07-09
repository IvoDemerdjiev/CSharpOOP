namespace OOPPrinciplesPartTwo
{
    using System;
    using Shapes;
    using System.Collections.Generic;
    using BankAccounts;
    using RangeExceptions;
    class Test
    {
        static void Main(string[] args)
        {
            var shapesList = new List<Shape>
            {
                new Triangle(6, 9),
                new Rectangle(4.4, 6.6),
                new Square(2),
                new Triangle(2.2, 3.4),
                new Rectangle(4.6, 4.55),
                new Square(11),
            };

            foreach (var shapes in shapesList)
            {
                Console.WriteLine(shapes.GetType().Name + " area is " + shapes.CalculateSurface());
            }


            /*var depositAcc = new Deposit(CustomerType.company, 12220, 4);
            Console.WriteLine(depositAcc.ToString());
            depositAcc.AddMoney(2000);
            depositAcc.WithdrawMoney(200);

            Console.WriteLine("Interest amount: {0}%" ,depositAcc.InterestAmount(8));

            Console.WriteLine(new string('-', 50));

            var loanAcc = new Loan(CustomerType.individual, 20000, 2);
            Console.WriteLine(loanAcc.ToString());
            depositAcc.AddMoney(2000);

            Console.WriteLine("Interest amount: {0}%", depositAcc.InterestAmount(8));

            Console.WriteLine(new string('-', 50));
            var mortgageAcc = new Mortgage(CustomerType.company, 34200, 3);
            Console.WriteLine(mortgageAcc.ToString());
            Console.WriteLine("Interest amount {0}%", mortgageAcc.InterestAmount(12));

            Console.WriteLine(new string('-', 50));*/

            /*try
            {
                int number = 300;
                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("Input not in range 1 100 ",1,100);
                }
            }

            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                DateTime date = new DateTime(1974, 10, 01);
                if (date < new DateTime(1977, 03, 11) || date > new DateTime(1980, 05, 15))
                {
                    throw new InvalidRangeException<DateTime>("Date not in range 1.1.1980-31.12.2013",
                    new DateTime(1980, 01, 01), new DateTime(2013, 12, 31));
                }
            }

            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }*/

        }
    }
}
