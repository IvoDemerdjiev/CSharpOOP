using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Workingdays
{
    class WorkingDays
    {
        static void Main(string[] args)
        {
            string input;
            DateTime newDate;
            Console.Write("Enter Date in this format (MM/DD/YYYY): ");
            input = Console.ReadLine();
            newDate = Convert.ToDateTime(input);
            DateTime oldDate = DateTime.Now;

            // Difference in days, hours, and minutes.
            TimeSpan ts = newDate - oldDate;
            // Difference in days.
            int differenceInDays = ts.Days;
            int weeks = differenceInDays / 7;
            Console.WriteLine("Difference in days: {0} ", differenceInDays);
            for (int i = newDate.Year; i <= oldDate.Year; i++)
            {
                int year = i;

                DateTime[] holidays = new DateTime[10];
                holidays[0] = new DateTime(year, 3, 3);
                holidays[1] = new DateTime(year, 5, 1);
                holidays[2] = new DateTime(year, 5, 6);
                holidays[3] = new DateTime(year, 5, 24);
                holidays[4] = new DateTime(year, 9, 6);
                holidays[5] = new DateTime(year, 9, 22);
                holidays[6] = new DateTime(year, 11, 1);
                holidays[7] = new DateTime(year, 12, 24);
                holidays[8] = new DateTime(year, 12, 26);
                holidays[9] = new DateTime(year, 12, 25);
                foreach (DateTime dt in holidays)
                {
                    if ((dt > oldDate) && (dt < newDate) && (dt.DayOfWeek != DayOfWeek.Saturday) && (dt.DayOfWeek != DayOfWeek.Sunday))
                        differenceInDays--;

                }
            }
            differenceInDays -= weeks * 2;
            Console.WriteLine("The number of working days is: " + differenceInDays);
        }
    }
}
