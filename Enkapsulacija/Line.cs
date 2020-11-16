using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulacija
{
    struct Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public readonly double X;
        public readonly double Y;
    }
    class Line
    {
        public Line(double k, double l)
        {
            a = -k;
            c = -l;
            b = 1;
        }
        public Line(Point p1, Point p2)
        {
            a = p1.Y - p2.Y;
            b = p2.X - p1.X;
            c = p1.X * p2.Y - p2.X * p1.Y;
        }
        public double Y(double x)
        {
            return -a / b * x - c / b;
        }
        private double a;
        private double b;
        private double c;

    }
}
