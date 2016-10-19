using System;

namespace kata.sensor.scratch
{
    public class Sensor : ISensor
    {
        public int GetValue()
        {
            var random = new Random();
            return random.Next();
        }
    }
}
