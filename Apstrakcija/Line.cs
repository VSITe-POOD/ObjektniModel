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
    class Line : ICurve
    {
        private double slope;
        private double yInterception;

        public Line(double slope, double yInterception)
        {
            this.slope = slope;
            this.yInterception = yInterception;
        }
        public double Y(double x)
        {
            return slope * x + yInterception;
        }
    }
}
