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
    }
}