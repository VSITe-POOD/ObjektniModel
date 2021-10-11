using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apstrakcija
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line(1, -1);

            for (int x = -10; x < 10; ++x)
                Console.WriteLine($"x={x}, y={line.Y(x)}");
            

            Console.ReadKey();
        }
    }
}
