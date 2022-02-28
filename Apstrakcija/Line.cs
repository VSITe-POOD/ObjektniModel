using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apstrakcija

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

	public Point? Intersection(Line other)
    {

    }
	public readonly double k;
	public readonly double l;
}
