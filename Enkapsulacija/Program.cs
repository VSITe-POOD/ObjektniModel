﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulacija
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line(1, -1);
            for (int x = -10; x < 10; ++x)
            {
                Console.WriteLine($"x={x},y={line.Y(x)}");
            }
            Line line2 = new Line(0, 2);
            // Console.WriteLine(line.GetIntersection(line2));
            foreach (var point in line.GetIntersection(line2))
            {
                Console.WriteLine(point);
            }
            Console.ReadLine();
        }
    }
}
