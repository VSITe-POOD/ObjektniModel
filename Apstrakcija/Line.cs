using System;

namespace Apstrakcija
{
	public struct Point
	{
		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}
		public readonly double X;
		public readonly double Y;
	}

	public class Line
	{
		public Line(double k, double l)
		{
			this.k = k;
			this.l = l;
		}

		public Point? Intersection(Line other)
		{
			if (k == other.k)
				return null;

			double x = (other.l - l) / (k - other.k);
			double y = k * x + 1;
			return new Point(x, y);
		}

		public readonly double k;
		public readonly double l;
	}
}

