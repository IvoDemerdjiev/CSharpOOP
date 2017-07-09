using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        static void Main()
        {
            double z = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double degrees = double.Parse(Console.ReadLine());
            double radians = degrees * Math.PI / 180;
            double area = ((z * x * (double)Math.Sin(radians)) / 2);
            Console.WriteLine("{0:F2}", area);
        }
    }
}
