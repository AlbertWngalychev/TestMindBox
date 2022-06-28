namespace Tests
{
    public class TestTriangle
    {
        [Fact]
        public void Perimetr_12()
        {
            Triangle tr = new(3, 4, 5);

            Assert.Equal(12, tr.Perimeter);
        }

        [Fact]
        public void Square_6()
        {
            Triangle tr = new(3, 4, 5);

            Assert.Equal(6, tr.Square);
        }

        [Fact]
        public void Rectangular()
        {
            Triangle tr = new(3, 4, 5);
            Assert.True(tr.IsRectangular);
        }

        public void Create2side1angle()
        {
            Triangle tr = Triangle.CreateWith2Side(3, 4, 90);
            Triangle tr3side = new(3, 4, 5);
            Assert.True(tr3side.Equals(tr));
        }
    }
}