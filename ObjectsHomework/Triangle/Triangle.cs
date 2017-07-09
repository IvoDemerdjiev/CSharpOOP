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
            Console.WriteLine("Enter 1 for three sides");
            Console.WriteLine("Enter 1 for side and hight");
            Console.WriteLine("Enter 3 for two sides and angle");
            int num = int.Parse(Console.ReadLine());
            if (num>0 && num<4)
            {
                switch (num)
                {
                    case 1:
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        double c = double.Parse(Console.ReadLine());
                        double p = (a + b + c) / 2;
                        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        Console.WriteLine(area);
                        return;
                    case 2:
                        double d = double.Parse(Console.ReadLine());
                        double hd = double.Parse(Console.ReadLine());
                        double area2 = (d * hd) / 2;
                        return;
                    default:
                        double z = double.Parse(Console.ReadLine());
                        double x = double.Parse(Console.ReadLine());
                        double sin = double.Parse(Console.ReadLine());
                        if (sin >= -1 && sin <= 1)
                        {
                            double area3 = ((z * x * Math.Sin(sin)) / 2);
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorect input");
            }
        }
    }
}
