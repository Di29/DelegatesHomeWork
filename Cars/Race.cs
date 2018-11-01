using System;
using System.Collections.Generic;

namespace Cars
{
    public class Race
    {
        public Finish Finish = car =>
        {
            Console.WriteLine("Победила машина: " + car.Name);
        };
        public Race()
        {
            Cars = new List<Car>();
        }
        public List<Car> Cars { get; set; }

        public bool MoveAll()
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].Move())
                {
                    Console.WriteLine("Гонки завершены!");
                    Reset();
                    return true;
                }
            }
            return false;
        }

        public void StartGame()
        {
            Cars.ForEach(car => car.Finisher += Finish);
        }
        private void Reset()
        {
            Cars.Clear();
        }
    }
}
