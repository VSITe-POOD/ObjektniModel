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

    public struct Point
    {
        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public readonly double x;
        public readonly double y;
        public  override string ToString()
        {
            return ($"({x},{y})");
        }
    }

    class Line : ICurve,IIntersection
    {
        public Line(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Line(double slope,double yIntercept)
        {
            a=- slope;
            b = 1;
            c=-yIntercept;
        }
        public double Y(double x)
        {
            return -(a * x) / b - (c / b);
            //return slope * x + yIntercept;
        }

        public List<Point> GetIntersection(Line other)
        {
            //if (slope == other.slope) 
            //    return new List<Point>();
            double denominator = a * other.b - (other.a * b);
            double x = b * other.c - other.b * c;
            double y = c * other.a - other.c * a;
            return new List<Point> { new Point(x/denominator, y/denominator) };
        }

        List<Point> IIntersection.GetIntersection(IIntersection other)
        {
            throw new NotImplementedException();
        }
        private double a;
        private double b;
        private double c;
        //private double slope;
        //private double yIntercept;
    }
}
