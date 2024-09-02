using ShapeMath.Shapes;

namespace ShapeMath.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void CircleAreaTest()
        {
            var circle = new Circle(10);
            Assert.Equal(314.1592653589793, circle.GetArea(), 10);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.GetArea(), 10);
        }

        [Fact]
        public void TriangleIsRightTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }
    }
}