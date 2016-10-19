namespace kata.sensor.scratch
{
    public class Alarm
    {
        private ISensor Sensor { get;}

        public Alarm(ISensor sensor)
        {
            Sensor = sensor;
        }

        public bool Status { get; set; }

        public void Check()
        {
            Status = false;
            var currentValue = Sensor.GetValue();
            if (currentValue < -21 || currentValue > 21)
            {
                Status = true;
            }
        }
    }
}
