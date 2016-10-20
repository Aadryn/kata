using System;
using NFluent;
using Xunit;

namespace kata.sensor.scratch.tests
{
    public class AlarmTests
    {
        [Fact]
        public void Example()
        {
            // Arranges
            var random = new Random();

            // Acts
            var result = random.Next(10, 100);

            // Asserts
            Check.That(result).IsAfter(9);
        }

    }
}
