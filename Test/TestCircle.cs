namespace Tests
{
    public class TestCircle
    {
        [Fact]
        public void Perimetr()
        {
            double radius = 2;
            double p = Math.PI * radius * 2;
            Circle circle = new(radius);


            Assert.Equal(p, circle.Perimeter);
        }

        [Fact]
        public void Square()
        {
            double radius = 2;
            double s = Math.PI * Math.Pow(radius, 2);
            Circle circle = new(radius);


            Assert.Equal(s, circle.Square);
        }
    }
}
