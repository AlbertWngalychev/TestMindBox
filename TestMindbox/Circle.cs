namespace TestMindbox
{
    public class Circle : IShape
    {
        public const double PI = Math.PI;
        public double Radius { get; init; }
        public double Square => PI*Math.Pow(Radius,2);
        public double Perimeter => 2*Radius*PI;
        public Circle(double radius)
        {
            if (radius <= 0) throw new Exception("Radius <= 0");
            Radius = radius;
        }
        public override bool Equals(object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Circle c = (Circle)obj;
            return (c.Radius==Radius);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Radius);
        }
    }
}