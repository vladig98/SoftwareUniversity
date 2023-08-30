using Moq;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Class1
    {
        [Test]
        public void TestMathAbs()
        {
            Mock<IFloor> fakeFloor = new Mock<IFloor>();
            Mock<IAbs> fakeAbs = new Mock<IAbs>();

            var obj = new Maths(fakeAbs.Object, fakeFloor.Object);
            var fakeValue = obj.Abs(-2.0000);
            var value = Math.Abs(-2.000);

            Assert.That(fakeValue, Is.EqualTo(value));
        }

        [Test]
        public void TestMathFloor()
        {
            Mock<IFloor> fakeFloor = new Mock<IFloor>();
            Mock<IAbs> fakeAbs = new Mock<IAbs>();

            var obj = new Maths(fakeAbs.Object, fakeFloor.Object);
            var fakeValue = obj.Floor(-2.0000);
            var value = Math.Floor(-2.000);

            Assert.That(fakeValue, Is.EqualTo(value));
        }
    }
}
    