using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passthetime
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Environment.TickCount & Int32.MaxValue;
            Console.WriteLine("Sec=" + result / 1000);
            Console.WriteLine("Min=" + (result / 1000) / 60);
            Console.WriteLine("Hour=" + (result / 1000) / 360);
        }
    }
}
