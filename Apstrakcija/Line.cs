using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Apstrakcija
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

        private double k;
        private double l;

        public Line(double k, double l)
        {
            this.k = k;
            this.l = l;
        }
        public Line(Point p1, Point p2)
        {
            k = (p2.y - p1.y) / (p2.x - p1.x);
            l = (p2.x * p1.y - p1.x * p2.y) / (p2.x - p1.x);
        }

        public double Y(double x)
        {
            return k*x+l;
        }
    }
}
