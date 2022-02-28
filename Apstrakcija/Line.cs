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
            K = k;
            L = l;
        }

        public Point? Intersection(Line other)
        {
            if (K == other.K)
            {
                return null;
            }
            double x = (other.L - L) / (K - other.K);
            double y = K * x + L;
            return new Point(x, y);
        }

        public readonly double K;
        public readonly double L;
    }
}
