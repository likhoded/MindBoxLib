namespace MindBoxLib.Tests
{
    [TestFixture]
    public class MindBoxTest
    {
        [Test]
        public void TriangleCalculationTest() // ТЕСТ: Вычисление площади треугольника
        {
            var triangle = new Triangle(3, 4, 5); //Arrange

            var triangleSquare = triangle.Square; //Act

            Assert.That(triangleSquare, Is.EqualTo(6)); //Assert
        }

        [Test]
        public void RectangularTriangleTest() // ТЕСТ: Тестирование прямого угла
        {
            var triangle = new Triangle(3, 4, 5); //Arrange

            var isTriangleRightAngled = triangle.IsRectangular;  //Act

            Assert.That(isTriangleRightAngled, Is.EqualTo(true)); //Assert
        }

        [Test]
        public void NoRectangularTriangleTest() // ТЕСТ: Тестирование не прямого угла
        {
            var triangle = new Triangle(6, 2, 5); //Arrange

            var isTriangleRightAngled = triangle.IsRectangular; //Act

            Assert.That(isTriangleRightAngled, Is.EqualTo(false)); //Assert
        }

        [Test]
        public void TriangleNegativeSidesTest() // ТЕСТ: Тестирование отрицательных сторон треугольника
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -1, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));
        }

        [Test]
        public void CircleNegativeRadiusTest()  // ТЕСТ: Тестирование отрицательного радиуса круга
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
        }

        [Test]
        public void CircleSqrCalculationTest() // ТЕСТ: Тестирование вычисления площади круга
        {
            var circle = new Circle(10); //Arrange

            var circleSquare = circle.Square; //Act

            Assert.That(circleSquare, Is.EqualTo(314.15926535897931)); //Assert
        }
    }
}