using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Apstrakcija
{
	struct Point
	{
		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}
		public readonly double X;
		public readonly double Y;
	}
	class Line
	{
		public Line(double k, double l)
		{
			this.k = k;
			this.l = l;
		}
		public Line(Point p1, Point p2)
		{
			k = ( p2.Y - p1.Y ) / ( p2.X - p1.X );
			l = ( p2.X * p1.Y - p1.X * p2.Y ) / ( p2.X - p1.X );
		}
		public double Y(double x)
		{
			return k * x + l;
		}

		public double X(double y)
		{
			return 0;
		}

		private double k;
		public double l;

	}
}
