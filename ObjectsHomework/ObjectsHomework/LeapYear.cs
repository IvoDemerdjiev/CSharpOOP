using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsHomework
{
    class LeapYear
    {
        public static string CheckLeapYear(int intyear)
        {
            if (intyear % 4 == 0 && intyear % 100 != 0 || intyear % 400 == 0)
            {
                return "Leap";
            }
            else
            {
                return "Common";
            }
        }
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckLeapYear(year));
        }
    }
}
