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

    struct Point
    {
        public Point(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public readonly double X, Y;

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }

    interface IIntersection
    {
        List<Point> GetIntersection(IIntersection other);
    }

    class Line : ICurve, IIntersection
    {
        public Line (double a, double b, double c)
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
            //return slope * x + yIntercept;
            return -a * x / b - c / b;
        }

        public List<Point> GetIntersection(Line other)
        {
            //if (slope == other.slope)
            //    return new List<Point>();
            double denominator = a * other.b - other.a * b;
            double x = b * other.c - other.b * c;
            double y = c * other.a - other.c * a;
            //double x = 0; // x koordinata sjecista za domaci rjesit
            //double y = 0; // y koordinata sjecista za domaci rjesit
            return new List<Point> { new Point(x / denominator, y / denominator) };
        }

        List<Point> IIntersection.GetIntersection(IIntersection other)
        {
            throw new NotImplementedException();
        }

        //private double slope;
        //private double yIntercept;
        private double a;
        private double b;
        private double c;
    }
}
