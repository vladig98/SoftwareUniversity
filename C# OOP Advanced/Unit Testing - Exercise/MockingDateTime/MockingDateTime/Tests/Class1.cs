using MockingDateTime;
using Moq;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Class1
    {
        [Test]
        public void TestIfYouCanAddADay()
        {
            Mock<ICustomDateTime> fakeDate = new Mock<ICustomDateTime>();

            var obj = new CustomDateTime(fakeDate.Object, new DateTime(2023, 08, 15));
            var fakeValue = obj.AddDays(2);

            Assert.That(fakeValue.ToString("dd-MM-yyyy"), Is.EqualTo("17-08-2023"));
        }

        [Test]
        public void TestIfYouCanAddNegativeDay()
        {
            Mock<ICustomDateTime> fakeDate = new Mock<ICustomDateTime>();

            var obj = new CustomDateTime(fakeDate.Object, new DateTime(2023, 08, 15));
            var fakeValue = obj.AddDays(-2);

            Assert.That(fakeValue.ToString("dd-MM-yyyy"), Is.EqualTo("13-08-2023"));
        }

        [Test]
        public void TestIfYouCanAddDaysToTheEndOfTheMonth()
        {
            Mock<ICustomDateTime> fakeDate = new Mock<ICustomDateTime>();

            var obj = new CustomDateTime(fakeDate.Object, new DateTime(2023, 08, 30));
            var fakeValue = obj.AddDays(10);

            Assert.That(fakeValue.ToString("dd-MM-yyyy"), Is.EqualTo("09-09-2023"));
        }

        [Test]
        public void TestIfYouCanAddNegativeDaysToTheBeginningOfTheMonth()
        {
            Mock<ICustomDateTime> fakeDate = new Mock<ICustomDateTime>();

            var obj = new CustomDateTime(fakeDate.Object, new DateTime(2023, 08, 1));
            var fakeValue = obj.AddDays(-2);

            Assert.That(fakeValue.ToString("dd-MM-yyyy"), Is.EqualTo("30-07-2023"));
        }

        [Test]
        public void TestIfYouCanAddDaysToALeapYear()
        {
            Mock<ICustomDateTime> fakeDate = new Mock<ICustomDateTime>();

            var obj = new CustomDateTime(fakeDate.Object, new DateTime(2020, 02, 28));
            var fakeValue = obj.AddDays(1);

            Assert.That(fakeValue.ToString("dd-MM-yyyy"), Is.EqualTo("29-02-2020"));
        }

        [Test]
        public void TestIfYouCanAddDaysToALeapYearWhenItsNotALeapYear()
        {
            Mock<ICustomDateTime> fakeDate = new Mock<ICustomDateTime>();

            var obj = new CustomDateTime(fakeDate.Object, new DateTime(2021, 02, 28));
            var fakeValue = obj.AddDays(1);

            Assert.That(fakeValue.ToString("dd-MM-yyyy"), Is.EqualTo("01-03-2021"));
        }

        [Test]
        public void TestIfYouCanAddADayToMinValue()
        {
            Mock<ICustomDateTime> fakeDate = new Mock<ICustomDateTime>();

            var obj = new CustomDateTime(fakeDate.Object, new DateTime(DateTime.MinValue.Year, DateTime.MinValue.Month, DateTime.MinValue.Day));
            var fakeValue = obj.AddDays(1);

            Assert.That(fakeValue.ToString("dd-MM-yyyy"), Is.EqualTo("02-01-0001"));
        }

        [Test]
        public void TestIfYouCanAddADayToMaxValue()
        {
            Mock<ICustomDateTime> fakeDate = new Mock<ICustomDateTime>();

            var obj = new CustomDateTime(fakeDate.Object, new DateTime(DateTime.MaxValue.Year, DateTime.MaxValue.Month, DateTime.MaxValue.Day));

            Assert.Throws<ArgumentOutOfRangeException>(() => obj.AddDays(1));
        }

        [Test]
        public void TestIfYouCanSubtractADayFromMinValue()
        {
            Mock<ICustomDateTime> fakeDate = new Mock<ICustomDateTime>();

            var obj = new CustomDateTime(fakeDate.Object, new DateTime(DateTime.MinValue.Year, DateTime.MinValue.Month, DateTime.MinValue.Day));
            
            Assert.Throws<ArgumentOutOfRangeException>(() => obj.AddDays(-1));
        }

        [Test]
        public void TestIfYouCanSubtractADayFromMaxValue()
        {
            Mock<ICustomDateTime> fakeDate = new Mock<ICustomDateTime>();

            var obj = new CustomDateTime(fakeDate.Object, new DateTime(DateTime.MaxValue.Year, DateTime.MaxValue.Month, DateTime.MaxValue.Day));
            var fakeValue = obj.AddDays(-1);

            Assert.That(fakeValue.ToString("dd-MM-yyyy"), Is.EqualTo("30-12-9999"));
        }
    }
}
