using NUnit.Framework;
using MindboxTask;
using FluentAssertions;

namespace MindboxTaskTests
{
    public class CircleTests
    {
        [Test]
        [TestCase(-1)]
        public void ShouldThrowOnBadValues(double radius)
        {
            Action act = () => { new Circle(radius); };
            act.Should().Throw<ArgumentException>();
        }

        [Test]
        [TestCase(2, 12.5663706143)]
        public void ShouldCalcArea(double radius, double area)
        {
            var circle = new Circle(radius);
            Assert.AreEqual(circle.GetArea(), area, 0.000001);
        }
    }
}
