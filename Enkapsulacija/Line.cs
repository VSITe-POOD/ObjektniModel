using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulacija
{
    class Line
    {
        public double Y(double x)
        {
            return -a / b * x - c / b;
        }
        private double a;
        private double b;
        private double c;

    }
}
