using System.Drawing;

namespace AreaLib
{
    public static class CMath
    {
        public static Point Plus(Point v1, Point v2) => new(v1.X + v2.X, v1.Y + v2.Y);
        public static Point Minus(Point v1, Point v2) => new(v1.X - v2.X, v1.Y - v2.Y);
        public static double Norm(Point v) => Math.Sqrt(v.X * v.X + v.Y * v.Y);
        public static double Norm2(Point v) => v.X * v.X + v.Y * v.Y;
        public static double Dist(Point p1, Point p2) => Norm(Minus(p1, p2));
        public static double VAngle(Point v1, Point v2) => Math.Acos(Dot(v1, v2) / (Norm(v1) * Norm(v2)));
        public static double Dot(Point v1, Point v2) => v1.X * v2.X + v1.Y * v2.Y;
        public static double AngleFrom3Edges(double edge0, double edge1, double oppositeEdge) => 
            Math.Acos(edge0*edge0 + edge1*edge1 - oppositeEdge*oppositeEdge) / (2*edge0*edge1);
    }
}