using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulacija
{
    interface ICurve
    {
        double Y(double x);
    }

    interface IIntersection
    {
        List<Point> GetIntersection(IIntersection other);
    }

    struct Point
    {
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"x = {this.x}  y = {this.y}";
        }
        public readonly double x, y;
    }

    class Line : ICurve, IIntersection
    {
        private double slope;
        private double yInterception;

        public Line(double slope, double yInterception)
        {
            this.a = -slope;
            this.b = 1;
            this.c = -yInterception;
        }

        public Line(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public List<Point> GetIntersection(Line other)
        {
            //if (slope == other.slope) new List<Point>();
            double denominator = a * other.b - other.a * b;
            double x = b * other.c - other.b * c;
            double y = c * other.a - other.c * a;      
            return new List<Point> { new Point(x / denominator, y / denominator) };
        }

        public double Y(double x)
        {
            //return slope * x + yInterception;
            return -a * x / b - c / b;
        }

        List<Point> IIntersection.GetIntersection(IIntersection other)
        {
            throw new NotImplementedException();
        }

        public double a, b, c;
    }
}
