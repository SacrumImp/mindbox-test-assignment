using MindBoxAreaLibrary;
using MindBoxAreaLibrary.Shapes;

namespace AreaTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Area_NullInput_ReturnNullException()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => AreaGetter.GetArea(null));

            Assert.That(ex.ParamName, Is.EqualTo("shape"));
        }

        [Test]
        public void Area_IncorrectInput_ReturnCastException()
        {
            var ex = Assert.Throws<InvalidCastException>(() => AreaGetter.GetArea(1));

            Assert.That(ex.Message, Is.EqualTo("This object does not implement IArea interface"));
        }

        [Test]
        public void Area_ZeroCircleInput_ReturnZero()
        {
            var circle = new Circle(0);

            var result = AreaGetter.GetArea(circle);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Area_CircleInput_ReturnCircleArea()
        {
            var circle = new Circle(5);

            var result = AreaGetter.GetArea(circle);

            Assert.That(result, Is.EqualTo(78.5398163397448275));
        }

        [Test]
        public void Area_RightTriangleInput_ReturnTriangleArea()
        {
            var circle = new Triangle(3, 4, 5);

            var result = AreaGetter.GetArea(circle);

            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Area_TriangleInput_ReturnTriangleArea()
        {
            var circle = new Triangle(2, 3, 4);

            var result = AreaGetter.GetArea(circle);

            Assert.That(result, Is.EqualTo(2.9047375096555625));
        }

        [Test]
        public void Area_InvalidTriangleInput_ReturnTriangleException()
        {
            var circle = new Triangle(1, 3, 1);

            var ex = Assert.Throws<ArgumentException>(() => AreaGetter.GetArea(circle));
            Assert.That(ex.Message, Is.EqualTo("There is no such triangle"));

            circle = new Triangle(3, 1, 1);

            ex = Assert.Throws<ArgumentException>(() => AreaGetter.GetArea(circle));
            Assert.That(ex.Message, Is.EqualTo("There is no such triangle"));

            circle = new Triangle(1, 1, 3);

            ex = Assert.Throws<ArgumentException>(() => AreaGetter.GetArea(circle));
            Assert.That(ex.Message, Is.EqualTo("There is no such triangle"));
        }

    }
}