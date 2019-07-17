using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            StartOfTheGame.StartText();
            int snakeSpeed = 100;
            bool correctLevel = false;

            string userLevel = Console.ReadLine();

            while(!correctLevel)
            {
                if (int.TryParse(userLevel, out int choosedLevel))
                {
                    if (choosedLevel == 1 || choosedLevel == 2 || choosedLevel == 3 || choosedLevel == 4)
                    {
                        snakeSpeed = Levels.ReturnSpeed(choosedLevel);
                        correctLevel = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect level. Try again");
                        userLevel = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Error! It wasn`t a number. Please, try again");
                    userLevel = Console.ReadLine();
                }
            }
            Console.Clear();

            int mapWeidth = 80;
            int mapHeight = 25;
            Random rnd = new Random();
            Walls walls = new Walls(mapWeidth, mapHeight);
            walls.Draw();


            Point startTailPoint = new Point(rnd.Next(5, mapWeidth - 5), rnd.Next(5, mapHeight - 5), '*');
            Snake snake = new Snake(startTailPoint, 5, Direction.Right);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(mapWeidth - 2, mapHeight - 2);
            Point foodForSnake = foodCreator.CreateFood(snake);
            foodCreator.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitWithTail())
                {
                    break;
                }
                if (snake.Eat(foodForSnake))
                {
                    foodForSnake = foodCreator.CreateFood(snake);
                    foodCreator.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(snakeSpeed);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo enteredKey = Console.ReadKey();
                    snake.EnteredKey(enteredKey);
                }
            }

            EndOfGame theEnd = new EndOfGame();
            theEnd.EndGameResult(snake, mapWeidth, mapHeight);
            theEnd.DrawEndGameResult();
            Console.ReadLine();
        }
    }
}
