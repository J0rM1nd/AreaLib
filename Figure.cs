namespace AreaLib
{
    public class Figure : IMeasurable
    {
        public const int DEFAULT_N = 1000;

        public delegate double Func(double x);

        public Func LowerBound;
        public Func UpperBound;
        public double XMin;
        public double XMax;

        public double Area(int n)
        {
            if (n <= 0)
                throw new Exception("n must be > 0");
            double dx = (XMax - XMin) / n;
            double s = 0;
            double x = XMin + dx / 2;
            for (int i = 0; i < n; i++)
            {
                s += dx * (UpperBound(x) - LowerBound(x));
                x += dx;
            }
            return s;
        }
        public double Perimeter(int n)
        {
            if (n <= 0)
                throw new Exception("n must be > 0");
            double dx = (XMax - XMin) / n;
            double dx2 = dx * dx;
            double s = (UpperBound(XMin) + UpperBound(XMax)) - (LowerBound(XMin) + LowerBound(XMax));
            double x = XMin;
            double dy;
            for (int i = 0; i < n; i++)
            {
                dy = UpperBound(x + dx) - UpperBound(x);
                s += Math.Sqrt(dx2 + dy * dy);
                dy = LowerBound(x + dx) - LowerBound(x);
                s += Math.Sqrt(dx2 + dy * dy);
                x += dx;
            }
            return s;
        }

        public double Area() => Area(DEFAULT_N);
        public double Perimeter() => Perimeter(DEFAULT_N);

        public Figure(Func lowerBound, Func upperBound, double xMin, double xMax)
        {
            if (XMin > XMax)
                throw new Exception("xMin must be < xMax ");
            LowerBound = lowerBound;
            UpperBound = upperBound;
            XMin = xMin;
            XMax = xMax;
        }
    }
}