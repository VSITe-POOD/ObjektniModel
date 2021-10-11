﻿using System;
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
        public Line(double slope,double yIntercept)
        {
            this.slope = slope;
            this.yIntercept = yIntercept;
        }
        public double Y(double x)
        {
            return slope * x + yIntercept;
        }

        public List<Point> GetIntersection(Line other)
        {
            List<Point> result = new List<Point>();
            if (slope == other.slope) 
                return new List<Point>();
            double x = 0;
            double y = 0;
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
