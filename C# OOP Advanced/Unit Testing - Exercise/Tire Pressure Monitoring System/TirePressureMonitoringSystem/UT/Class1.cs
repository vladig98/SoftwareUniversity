using Moq;
using NUnit.Framework;
using System;
using TirePressureMonitoringSystem;

namespace UT
{
    public class Class1
    {
        [Test]
        public void TestIfAlarmIsOff()
        {
            Mock<ISensor> fakeSensor = new Mock<ISensor>();
            Mock<Alarm> fakeAlarm = new Mock<Alarm>(fakeSensor.Object);

            Assert.That(fakeAlarm.Object.AlarmOn, Is.EqualTo(false));
        }

        //CHAT GPT GENERATED TESTS

        //I used the AI to generate the tests because I did not want to modify the original classes
        //it turns out that you need an interface to mock these methods

        [Test]
        public void Check_AlarmOnLowPressureThreshold_AlarmShouldBeOn()
        {
            // Arrange
            var sensorMock = new Mock<ISensor>();
            sensorMock.Setup(sensor => sensor.PopNextPressurePsiValue()).Returns(16.0);  // Below LowPressureThreshold
            var alarm = new Alarm(sensorMock.Object);

            // Act
            alarm.Check();

            // Assert
            Assert.IsTrue(alarm.AlarmOn);
        }

        [Test]
        public void Check_AlarmOnHighPressureThreshold_AlarmShouldBeOn()
        {
            // Arrange
            var sensorMock = new Mock<ISensor>();
            sensorMock.Setup(sensor => sensor.PopNextPressurePsiValue()).Returns(22.0);  // Above HighPressureThreshold
            var alarm = new Alarm(sensorMock.Object);

            // Act
            alarm.Check();

            // Assert
            Assert.IsTrue(alarm.AlarmOn);
        }

        [Test]
        public void Check_AlarmWithinThreshold_AlarmShouldBeOff()
        {
            // Arrange
            var sensorMock = new Mock<ISensor>();
            sensorMock.Setup(sensor => sensor.PopNextPressurePsiValue()).Returns(18.0);  // Within threshold
            var alarm = new Alarm(sensorMock.Object);

            // Act
            alarm.Check();

            // Assert
            Assert.IsFalse(alarm.AlarmOn);
        }
    }
}
