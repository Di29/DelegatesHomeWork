namespace Cars
{
    public delegate void Finish(Car car);

    public abstract class Car
    {
        public Car()
        {
            Position = 0;
            ChangeSpeed();
        }
        protected const int MINIMAL_SPEED = 1;
        private const int FINISH_LINE = 100;

        public event Finish Finisher;
        public int Speed { get; protected set; }
        public string Name { get; set; }
        public int Position { get; set; }

        public abstract void ChangeSpeed();
        public bool Move()
        {
            Position += Speed;
            ChangeSpeed();
            if (Position >= FINISH_LINE)
            {
                Finisher(this);
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return string.Format("Имя: {0,10} Позиция: {1,-15}", Name, Position);
        }
    }
}
