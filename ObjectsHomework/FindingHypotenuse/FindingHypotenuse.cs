using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingHypotenuse
{
    class FindingHypotenuse
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first leg:");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second leg:");
            double b = int.Parse(Console.ReadLine());
            double c = Math.Sqrt(a*a + b*b);
            Console.WriteLine("Hypotenuse=" + c);
        }
    }
}
