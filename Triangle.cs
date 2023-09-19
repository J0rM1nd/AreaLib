using System.Drawing;
using static AreaLib.CMath;
//Making triangle with 3 any point
//If you need rightness, use Angle
namespace AreaLib
{
    public class Triangle : IMeasurable
    {
        Point Vertex0 { get; set; }
        Point Vertex1 { get; set; }
        Point Vertex2 { get; set; }

        double Edge0 { get => Dist(Vertex0, Vertex1); }
        double Edge1 { get => Dist(Vertex1, Vertex2); }
        double Edge2 { get => Dist(Vertex2, Vertex0); }

        double Angle0 { get => VAngle(Minus(Vertex1, Vertex0), Minus(Vertex2, Vertex0)); }
        double Angle1 { get => VAngle(Minus(Vertex0, Vertex1), Minus(Vertex2, Vertex1)); }
        double Angle2 { get => VAngle(Minus(Vertex0, Vertex2), Minus(Vertex1, Vertex2)); }
        

        public double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - Edge0) * (s - Edge1) * (s - Edge2));
        }

        public double Perimeter() => Edge0 + Edge1 + Edge2;

        public Triangle(Point vertex0, Point vertex1, Point vertex2)
        {
            Vertex0 = vertex0;
            Vertex1 = vertex1;
            Vertex2 = vertex2;
        }
    }
}