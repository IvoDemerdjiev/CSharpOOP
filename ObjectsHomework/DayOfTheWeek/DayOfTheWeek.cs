using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheWeek
{
    class DayOfTheWeek
    {
        static void Main(string[] args)
        {
            DateTime dateValue = DateTime.Now;
            int day=(int)dateValue.DayOfWeek;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Today is monday.");
                    return;
                case 2:
                    Console.WriteLine("Today is tuesday.");
                    return;
                case 3:
                    Console.WriteLine("Today is wednesday.");
                    return;
                case 4:
                    Console.WriteLine("Today is thursday.");
                    return;
                case 5:
                    Console.WriteLine("Today is friday.");
                    return;
                case 6:
                    Console.WriteLine("Today is saturday.");
                    return;
                default:
                    Console.WriteLine("Today is sunday.");
                    break;
            }
        }
    }
}
