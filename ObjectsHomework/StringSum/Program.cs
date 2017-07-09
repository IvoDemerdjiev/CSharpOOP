using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            int sum = 0;
            foreach (var numbers in words)
            {
                sum += Convert.ToInt32(numbers);
            }
            Console.WriteLine(sum);
        }
    }
}
