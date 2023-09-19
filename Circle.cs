using System.Drawing;

namespace AreaLib
{
    public class Circle : IMeasurable
    {
        Point Center { get; set; }
        double Radius { get; set; }

        public double Area() => Math.PI * Radius * Radius;
        public double Perimeter() => 2 * Math.PI * Radius;

        public Circle(double radius, Point center = new Point())
        {
            Center = center;
            Radius = radius;
        }
    }
}