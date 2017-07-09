using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int number = 1; number <= 10; number++)
            {
                int randomNumber = rand.Next(199) + 1;
                if (randomNumber>=100 && randomNumber<=200 )
                {
                    Console.Write("{0} ", randomNumber);
                }
                else
                {
                    number--;
                }
            }
            Console.WriteLine();
        }
    }
}
