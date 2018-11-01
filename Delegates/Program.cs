using System;
using Cars;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race();
            bool isStarted = false;

            while (true)
            {
                if (isStarted)
                {
                    Console.Clear();
                    race.Cars.ForEach(car => Console.WriteLine(car));
                    Console.WriteLine("Нажмите ENTER");
                    Console.ReadLine();
                    if (race.MoveAll())
                    {
                        isStarted = false;
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1 - Добавить автобус");
                    Console.WriteLine("2 - Добавить грузовик");
                    Console.WriteLine("3 - Добавить легкое авто");
                    Console.WriteLine("4 - Добавить спортивную машину");

                    Console.WriteLine("0 - Начать гонку");
                    Console.Write("Выберите команду: ");

                    int choise;
                    while (!int.TryParse(Console.ReadLine(), out choise))
                    {
                        Console.Clear();
                        Console.WriteLine("Ошибка! Введите корректную цифру: ");
                    }

                    if (choise >= 1 && choise <= 4)
                    {
                        Console.Write("Введите название авто: ");
                        string name = Console.ReadLine();
                        switch (choise)
                        {
                            case 1:
                                race.Cars.Add(new Bus(name));
                                break;
                            case 2:
                                race.Cars.Add(new Lorry(name));
                                break;
                            case 3:
                                race.Cars.Add(new LightCar(name));
                                break;
                            case 4:
                                race.Cars.Add(new SportCar(name));
                                break;
                        }
                    }
                    else if (choise == 0)
                    {
                        isStarted = true;
                        race.StartGame();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Некорректная цифра");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
