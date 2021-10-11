using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apstrakcija
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
        public Line(double slope, double yInterception)
        {
            this.slope = slope;
            this.yInterception = yInterception;
        }
        public double Y(double x)
        {
            return slope * x + yInterception;
        }

        public List<Point> GetIntersection(Line other)
        {
            if (slope == other.slope)
                return new List<Point>();
            double x = 0; // x kordinata sjecista
            double y = 0; // y kordinata sjecista
            return new List<Point> { new Point(x, y) };
        }

        List<Point> IIntersection.GetIntersection(IIntersection other)
        {
            throw new NotImplementedException();
        }

        private double slope;
        private double yInterception;
    }
}
