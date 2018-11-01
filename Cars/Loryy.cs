using System;

namespace Cars
{
    public class Lorry : Car
    {
        public Lorry(string name = "") : base()
        {
            Name = name;
        }
        private const int MAXIMAL_SPEED = 9;

        public override void ChangeSpeed()
        {
            Random random = new Random();
            Speed = random.Next(MINIMAL_SPEED, MAXIMAL_SPEED);
        }
    }
}
