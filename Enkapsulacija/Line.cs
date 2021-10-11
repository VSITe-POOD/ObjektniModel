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
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public readonly double X;
        public readonly double Y;
    }

    class Line : ICurve, IIntersection
    {
        public Line(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Line(double slope, double yInterception)
        {
            a = -slope;
            b = 1;
            c = -yInterception;
        }
        public double Y(double x)
        {
            //return slope * x + yInterception;
            return -a * x / b - c / b;
        }

        public List<Point> GetIntersection(Line other)
        {
            //if (slope == other.slope)
            //    return new List<Point>();
            double denominator = a * other.b - other.a * b;
            double x = b * other.c - other.b * c;
            double y = c * other.a - other.c * a;
            return new List<Point> { new Point(x / denominator, y / denominator) };
        }

        List<Point> IIntersection.GetIntersection(IIntersection other)
        {
            throw new NotImplementedException();
        }

        //private double slope;
        //private double yInterception;
        private double a;
        private double b;
        private double c;
    }
}
