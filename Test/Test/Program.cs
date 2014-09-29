using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public static void Main()
        {
            Sphere s = new Sphere(Color.Blue, 22);

            IHasVolume h = new Sphere(10);

            s.calcVolume();

            h.calcVolume();

            Console.WriteLine(s.ToString());

            Console.WriteLine(h.ToString());

            Console.ReadLine();

            


        }
    }
}
