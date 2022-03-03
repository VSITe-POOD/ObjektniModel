using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apstrakcija
{

    struct Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public readonly double X;
        public readonly double Y;

    }
    class Line
    {
        public Line(double k, double l)
        {
            this.K = k;
            this.L = l;
        }

        public readonly double K;
        public readonly double L;
    }
}
