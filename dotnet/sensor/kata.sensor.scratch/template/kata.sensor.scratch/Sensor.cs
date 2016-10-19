using System;

namespace kata.sensor.scratch
{
    public class Sensor
    {
        public int GetValue()
        {
            var random = new Random();
            return random.Next();
        }
    }
}
