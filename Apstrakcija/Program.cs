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
            Line line1 = new Line(1, 0);

            double x = 3;
            Console.WriteLine($"y ({x}) = {line1.Y(x)}");

            Line line2 = new Line(2, 0);

            double x2 = 3;
            Console.WriteLine($"y ({x2}) = {line2.Y(x2)}");


            Line line3 = new Line(2, 0);

            double x3 = 3;
            Console.WriteLine($"y ({x3}) = {line3.Y(x3)}");

            Point p1 = new Point(1, 2);
            Point p2 = new Point(4, 7);

            double x4 = 4;
            Line line4 = new Line(p1, p2);
            Console.WriteLine($"y({x4}) = {line4.Y(x4)}");


            Console.ReadKey();

        }
    }
}
