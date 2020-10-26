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
            line Line1 = new line(1, 0);
            double x = 3;
            Console.WriteLine($"y({x}) = {Line1.Y(x)}");

            line Line2 = new line(2, 0);
            Console.WriteLine($"y({x}) = {Line2.Y(x)}");

            line Line3 = new line(2, -1);
            Console.WriteLine($"y({x}) = {Line3.Y(x)}");

            Point p1 = new Point(1, 2);
            Point p2 = new Point(4, 7);
            line Line4 = new line(p1,p2);
            Console.Write($"y(4) = {Line4.Y(4)}");
            Console.ReadKey();

        }
    }
}
