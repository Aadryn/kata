using System;
using Moq;
using NFluent;
using Xunit;

namespace kata.sensor.scratch.tests
{
    public class AlarmTests
    {
        [Fact]
        public void TheAlarmShouldBeOffWhenInitialized()
        {
            // Arranges
            var mockedSensor = new Mock<ISensor>();
            var alarm = new Alarm(mockedSensor.Object);

            // Acts

            // Asserts
            Check.That(alarm.Status).IsFalse();
        }

        [Fact]
        public void TheAlarmShouldBeOnWhenTheSensorReturnAValueBelowThanMinusTwentyOne()
        {
            // Arranges
            var mockedSensor = new Mock<ISensor>();
            mockedSensor.Setup(method => method.GetValue()).Returns(-22);
            var alarm = new Alarm(mockedSensor.Object);

            // Acts
            alarm.Check();

            // Asserts
            Check.That(alarm.Status).IsTrue();
        }

        [Fact]
        public void TheAlarmShouldBeOnWhenTheSensorReturnAValueUpperThanTwentyOne()
        {
            // Arranges
            var mockedSensor = new Mock<ISensor>();
            mockedSensor.Setup(method => method.GetValue()).Returns(22);
            var alarm = new Alarm(mockedSensor.Object);

            // Acts
            alarm.Check();

            // Asserts
            Check.That(alarm.Status).IsTrue();
        }

        [Fact]
        public void TheAlarmShouldBeOffWhenTheSensorReturnAValueBetweenUpperAndLowerBound()
        {
            // Arranges
            var mockedSensor = new Mock<ISensor>();
            mockedSensor.Setup(method => method.GetValue()).Returns(0);
            var alarm = new Alarm(mockedSensor.Object);

            // Acts
            alarm.Check();

            // Asserts
            Check.That(alarm.Status).IsFalse();
        }

        [Fact]
        public void TheAlarmShouldAlwaysBeRestToReturnTheValidResult()
        {
            // Arranges
            var mockedSensor = new Mock<ISensor>();
            mockedSensor.SetupSequence(method => method.GetValue())
                .Returns(-22)
                .Returns(0);
            var alarm = new Alarm(mockedSensor.Object);

            // Acts
            alarm.Check();
            Check.That(alarm.Status).IsTrue();
            alarm.Check();

            // Asserts
            Check.That(alarm.Status).IsFalse();
        }
    }
}
