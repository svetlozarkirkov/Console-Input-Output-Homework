using System;
using System.Collections.Generic;
using System.Threading;

struct Car
{
    public int x;
    public int y;
    public string c;
    public ConsoleColor color;
}

class FallingRocks
{
    private static Random _random = new Random();
    private static Random randomCar = new Random();

    static void PrintOnPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void Main()
    {
        int score = 0;
        int playfieldWidth = 25;
        int livesCount = 5;
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 50;
        Car userCar = new Car();
        userCar.x = 2;
        userCar.y = Console.WindowHeight - 1;
        userCar.c = "0";
        userCar.color = ConsoleColor.White;
        Random randomStartingPosition = new Random();
        Random randomColor = new Random();
        List<Car> cars = new List<Car>();
        string[] carsVariations = new string[]{"^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";", "-"};

        while (true)
        {
            bool hit = false;
            {
                Car newCar = new Car();
                newCar.color = GetRandomConsoleColor();
                newCar.x = randomStartingPosition.Next(0, playfieldWidth);
                newCar.y = 0;
                int randomCarStart = randomCar.Next(0, carsVariations.Length);
                newCar.c = carsVariations[randomCarStart];
                cars.Add(newCar);
            }

            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userCar.x - 1 >= 0)
                    {
                        userCar.x = userCar.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (userCar.x + 1 < playfieldWidth)
                    {
                        userCar.x = userCar.x + 1;
                    }
                }
            }

            List<Car> newList = new List<Car>();

            for (int i = 0; i < cars.Count; i++)
            {
                Car oldCar = cars[i];
                Car newCar = new Car();
                newCar.x = oldCar.x;
                newCar.y = oldCar.y + 1;
                newCar.c = oldCar.c;
                newCar.color = oldCar.color;
                if (newCar.x == userCar.x && newCar.y == userCar.y)
                {
                    livesCount--;
                    hit = true;
                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(32, 10, "GAME OVER!", ConsoleColor.Red);
                        PrintStringOnPosition(32, 12, "Press [Enter]...", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                if (newCar.y < Console.WindowHeight)
                {
                    newList.Add(newCar);
                }
            }

            cars = newList;
            Console.Clear();
            PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
            foreach (Car car in cars)
            {
                PrintOnPosition(car.x, car.y, car.c, car.color);
            }
            if (hit)
            {
                cars.Clear();
                PrintOnPosition(userCar.x, userCar.y, "X", ConsoleColor.Red);
                PrintStringOnPosition(35, 4, "Lives: " + livesCount, ConsoleColor.White);
                PrintStringOnPosition(35, 2, "Score: " + score, ConsoleColor.White);
                PrintStringOnPosition(33, 10, "You crashed!", ConsoleColor.Red);
                PrintStringOnPosition(31, 12, "Press [Enter] ...", ConsoleColor.Red);
                Console.ReadKey();
            }
            else
            {
                PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
                score += 5;
            }
            PrintStringOnPosition(35, 4, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnPosition(35, 2, "Score: " + score, ConsoleColor.White);
            Thread.Sleep((int)(150));
        }
    }
    private static ConsoleColor GetRandomConsoleColor()
    {
        var consoleColors = Enum.GetValues(typeof(ConsoleColor));
        return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
    }

}