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
        private readonly double K;
        private readonly double L;

        public Line(double k, double l)
        {
            this.K = k;
            this.L = l;
        }

        public Point? Intersection(Line other)
        {
            if (this.K == other.K)
            {
                return null;
            }

            var x = (other.L - this.L) / (this.K - other.K);
            var y = this.K * x + this.L;

            return new Point(x, y);
        }
    }
}
