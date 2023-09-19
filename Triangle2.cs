//First of all, not any 3 numbers >= 0 makes a triangle by triangle inequality (1)
//Next bad idea is finding right triangle. If you whant to have 100% right right triangle you need other class (2)
//Finding angle as function offаloating-point number does not provide a guarantee rightness of triangle (3)
//Also pythagorean theorem can't help with this problem if we use float or double values (4)
//If you need rightness, use Angle
using static AreaLib.CMath;

namespace AreaLib
{
    public class Triangle2 : IMeasurable
    {
        double Edge0 { get; }
        double Edge1 { get; }
        double Edge2 { get; }

        public double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - Edge0) * (s - Edge1) * (s - Edge2));
        }
        public double Perimeter() => Edge0 + Edge1 + Edge2;

        double Angle0 { get => AngleFrom3Edges(Edge1, Edge2, Edge0); }
        double Angle1 { get => AngleFrom3Edges(Edge0, Edge2, Edge1); }
        double Angle2 { get => AngleFrom3Edges(Edge0, Edge1, Edge2); }

        public Triangle2(double edge0, double edge1, double edge2)
        {
            if (edge0 > (edge1 + edge2) || edge1 > (edge2 + edge0) || edge2 > (edge0 + edge1))
                throw new Exception("Check triangle inequality");
            Edge0 = edge0;
            Edge1 = edge1;
            Edge2 = edge2;
        }
    }
}