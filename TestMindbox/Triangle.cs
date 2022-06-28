namespace TestMindbox
{
    public class Triangle : IShape
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }
        public double Square
        {
            get
            {
                double sp = Perimeter / 2;
                return Math.Sqrt(sp * (sp - SideA) * (sp - SideB) * (sp - SideC));
            }
        }
        public double Perimeter => SideA + SideB + SideC;
        public bool IsRectangular => Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2);
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0) throw new Exception("Side A <= 0 or null");
            if (sideB <= 0) throw new Exception("Side B <= 0 or null");
            if (sideC <= 0) throw new Exception("Side C <= 0 or null");

            if (!(sideA + sideB > sideC
                && sideA + sideC > sideB
                && sideB + sideC > sideA))
            {
                throw new Exception("Can't create a triangle");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        private Triangle() { }
        public static Triangle CreateWith2Side(double sideA, double sideB, double angelBetween)
        {
            double cos = Math.Cos(radian ? angelBetween : angelBetween * Math.PI / 180);
            double sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - 2 * sideA * sideB * cos);

            return new(sideA, sideB,sideC);
        }

        public override bool Equals(object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Triangle tr = (Triangle)obj;
            return (tr.SideA == SideA) && (tr.SideB == SideB) && (tr.SideC == SideC);

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SideA, SideB, SideC);
        }
    }
}