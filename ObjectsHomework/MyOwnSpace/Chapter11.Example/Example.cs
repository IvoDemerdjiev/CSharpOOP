using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnSpace.Chapter11.Example
{
    class Example
    {
        static void Main()
        {
            Cat[] cats = new Cat[10];
            for (int i = 0; i <cats.Length; i++)
            {
                cats[i] = new Cat("Cat" + Sequence.NextValue(),"White");
            }
            foreach (var cat in cats)
            {
                cat.SayMiau();
            }
        }
    }
}
