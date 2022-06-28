namespace Tests
{
    public class TestShape
    {
        [Fact]
        public void ShapeArray()
        {
            IShape[] shapes = new IShape[]
            {
                new Triangle(3,4,5),
                new Circle(2),
            };

            Assert.All(shapes, (s) =>
            {
                if (s is Circle)
                {
                    Circle circle = (Circle)s;
                    double radius = circle.Radius;

                    double sq = Math.PI * Math.Pow(radius, 2);

                    Assert.Equal(sq, circle.Square);
                }
                else if(s is Triangle)
                {
                    Triangle triangle = (Triangle)s;
                    double p = triangle.SideA + triangle.SideB + triangle.SideC;

                    Assert.Equal(p, triangle.Perimeter);
                }
            });
        }
    }
}
