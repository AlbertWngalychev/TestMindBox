using TestMindbox.Interfaces;

namespace TestMindbox
{
    public class Circle : IShape, IEquatable<Circle>
    {
        private readonly double _radius;

        public const double PI = Math.PI;
        public double Radius => _radius;
        public double GetSquare() => PI*Math.Pow(_radius,2);
        public double GetPerimeter() => 2 * _radius * PI;
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Radius <= 0");
            }

            _radius = radius;
        }
        public override bool Equals(object? obj)
        {
            if (obj is null || !GetType().Equals(obj.GetType()))
            {
                return false;
            }

            Circle circle = (Circle)obj;
            return Equals(circle);
        }
        public static bool operator ==(Circle circle1, Circle circle2)
        {
            return circle1.Equals(circle2);
        }
        public static bool operator !=(Circle circle1, Circle circle2)
        {
            return !circle1.Equals(circle2);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(_radius);
        }
        public bool Equals(Circle? other)
        {
            return other is not null && _radius == other.Radius;
        }
    }
}