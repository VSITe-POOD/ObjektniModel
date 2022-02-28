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
            Line l1 = new Line(1, 0);
            Line l2 = new Line(0, 1);
            Point? p = l1.Intersection(l2);
            if (p.HasValue)
                Console.WriteLine($"Intersection: {p.Value.X}, {p.Value.Y}");
            else
            {
                Console.WriteLine("Lines are parallel");
            }
            Console.ReadKey();
        }
    }
}
