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
            for(int i = -10; i <= 10; ++i)
            {
                Console.WriteLine($"(x={i}, y={line.Y(i)}");
                
                Console.ReadKey();
            }
        }
    }
}
