using System;


namespace Apstrakcija
{
    public class Program
    {
        static void Main(string[] args)
        {
            var l1 = new Line(1, 0);
            var l2 = new Line(0, 1);

            var p1 = l1.Intersection(l2);

            if (p1.HasValue)
            {
                Console.WriteLine($"Intersection L1 Vs L2: ({p1.Value.X}, {p1.Value.Y})");
            }
            else
            {
                Console.WriteLine($"Lines are parallel");
            }

            var p2 = l2.Intersection(l1);

            if (p2.HasValue)
            {
                Console.WriteLine($"Intersection L2 vs L1: ({p2.Value.X}, {p2.Value.Y})");
            }
            else
            {
                Console.WriteLine($"Lines are parallel");
            }

            Console.ReadLine();           
        }
    }
}
