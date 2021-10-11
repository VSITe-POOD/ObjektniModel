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
        List<Point>GetIntersection(IIntersection other);
    }

    class Line : ICurve, IIntersection
    {
        public Line(double slope, double yInterception)
        {
            this.slope = slope;
            yIntercept = yInterception;
        }
        public double Y(double x)
        {
            return slope * x + yIntercept;
        }

        public List<Point> GetIntersection(Line other)
        {
            if (slope == other.slope)
                return new List<Point>();
            double x = 0; // x koordinata sjecista za domaci rjesit
            double y = 0; // y koordinata sjecista za domaci rjesit
            return new List<Point> { new Point(x, y) };
        }

        List<Point> IIntersection.GetIntersection(IIntersection other)
        {
            throw new NotImplementedException();
        }

        private double slope;
        private double yIntercept;
    }
}
