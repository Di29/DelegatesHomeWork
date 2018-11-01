using System;

namespace Cars
{
    public class SportCar : Car
    {
        public SportCar(string name = "") : base()
        {
            Name = name;
        }
        private const int MAXIMAL_SPEED = 17;

        public override void ChangeSpeed()
        {
            Random random = new Random();
            Speed = random.Next(MINIMAL_SPEED, MAXIMAL_SPEED);
        }
    }
}
