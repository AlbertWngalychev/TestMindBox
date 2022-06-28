using System;
using System.Data.Common;

namespace TestMindbox
{
    public class Triangle : IShape, IEquatable<Triangle>
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public double SideA => _sideA;
        public double SideB => _sideB;
        public double SideC => _sideC;
        public double GetSquare()
        {
            double sp = GetPerimeter() / 2;
            return Math.Sqrt(sp * (sp - SideA) * (sp - SideB) * (sp - SideC));
        }
        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
        public bool IsRectangular
        {
            get
            {
                double sideA2 = Math.Pow(_sideA, 2);
                double sideB2 = Math.Pow(_sideB, 2);
                double sideC2 = Math.Pow(_sideC, 2);

                return sideA2 + sideB2 == sideC2
                    || sideB2 + sideC2 == sideA2
                    || sideC2 + sideA2 == sideB2;
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!canCreate(sideA, sideB, sideC))
            {
                throw new Exception("Can't create a triangle");
            }
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        static bool canCreate(double sideA, double sideB, double sideC)
        {
            return sideA > 0
                && sideB > 0
                && sideC > 0
                && sideA + sideB > sideC
                && sideA + sideC > sideB
                && sideB + sideC > sideA;
        }
        public bool Equals(Triangle? other)
            => other is not null 
            && SideA == other.SideA
            && SideB == other.SideB
            && SideC == other.SideC;
        public override bool Equals(object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            Triangle tr = (Triangle)obj;

            return Equals(tr);
        }

        public static bool operator ==(Triangle triangle1, Triangle triangle2)
        {
            return triangle1.Equals(triangle2);
        }
        public static bool operator !=(Triangle triangle1, Triangle triangle2)
        {
            return !triangle1.Equals(triangle2);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(SideA, SideB, SideC);
        }

    }
}