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
            this.slope = slope;
            this.yInterception = yInterception;
        }

        public List<Point> GetIntersection(Line other)
        {
            if (slope == other.slope) new List<Point>();
            double x = 0; //X koordinata sjecišta
            double y = 0; //Y koordinata sjecišta
            return new List<Point> { new Point(x, y) };
        }

        public double Y(double x)
        {
            return slope * x + yInterception;
        }

        List<Point> IIntersection.GetIntersection(IIntersection other)
        {
            throw new NotImplementedException();
        }
    }
}
