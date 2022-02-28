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
            //try
            //{
            //    double k1 = double.Parse(args[0]);
            //    double l1 = double.Parse(args[1]);
            //    double k2 = double.Parse(args[2]);
            //    double l2 = double.Parse(args[3]);

            //    if (k1 == k2)
            //        Console.WriteLine("Lines are parallel");
            //    else
            //    {
            //        double x = (l2 - l1) / (k1 - k2);
            //        double y = k1 * x + l1;
            //        Console.WriteLine($"Intersection: ({x}, {y})");
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid entry");
            //}

            Line l1 = new Line(1, 0);
            Line l2 = new Line(0, 1);
            Point? p = l1.Intersection(l2);
            if (p.HasValue)
                Console.WriteLine($"Intersection: ({p.Value.X}, {p.Value.Y})");
            else
                Console.WriteLine("Lines are paralell!");
            Console.ReadLine();
        }
    }
}
