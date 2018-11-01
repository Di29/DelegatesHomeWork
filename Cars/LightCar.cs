using System;

namespace Cars
{
    public class LightCar : Car
    {
        public LightCar(string name = "") : base()
        {
            Name = name;
        }
        private const int MAXIMAL_SPEED = 14;

        public override void ChangeSpeed()
        {
            Random random = new Random();
            Speed = random.Next(MINIMAL_SPEED, MAXIMAL_SPEED);
        }
    }
}
