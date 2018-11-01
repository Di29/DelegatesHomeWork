using System;

namespace Cars
{
    public class Bus : Car
    {
        public Bus(string name = "") : base()
        {
            Name = name;
        }
        private const int MAXIMAL_SPEED = 7;

        public override void ChangeSpeed()
        {
            Random random = new Random();
            Speed = random.Next(MINIMAL_SPEED, MAXIMAL_SPEED);
        }
    }
}
