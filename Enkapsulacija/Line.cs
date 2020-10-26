using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulacija
{
    struct Point
    {
        public readonly double x;
        public readonly double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Line
    {
        private double a;
        private double b;
        private double c;

        public Line(Point p1, Point p2)
        {
           
        }
        public double Y(double x)
        {
            return -a / b * x - c / b;
        }
    }
}
