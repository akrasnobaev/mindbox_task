using NUnit.Framework;
using MindboxTask;
using FluentAssertions;

namespace MindboxTaskTests
{
    [TestFixture]
    internal class TriangleTests
    {
        [Test]
        [TestCase(-1, 1, 1, 1)]
        [TestCase(1, -1, 1, 1)]
        [TestCase(1, 1, -1, 1)]
        [TestCase(1, 1, 1, -1)]
        public void ShouldThrowOnBadArgument(double a, double b, double c, double tolerance)
        {
            Action act = () => { new Triangle(a, b, c, tolerance); };
            act.Should().Throw<ArgumentException>();
        }

        [Test]
        [TestCase(2, 12.5663706143)]
        public void ShouldCalcArea(double radius, double area)
        {
            var circle = new Circle(radius);
            Assert.AreEqual(circle.GetArea(), area, 0.000001);
        }

        [Test]
        [TestCase(1, 2, 5, 0.0000000001, true)]
        [TestCase(1, 2, 6, 0.0000000001, false)]
        [TestCase(1, 2, 6, 2, true)]
        void ShouldCheckForRightAngle(double a, double b, double c, double tolerance, bool isRightAngled)
        {
            Assert.AreEqual(new Triangle(a, b, c, tolerance).IsRightAngled(), isRightAngled);
        }
    }
}
