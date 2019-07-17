using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class FoodCreator : Point
    {
        private int _mapWeigth;
        private int _mapHight;


        Random rnd = new Random();

        public FoodCreator(int mapWeigth, int mapHight)
        {
            _mapHight = mapHight;
            _mapWeigth = mapWeigth;
        }

        public Point CreateFood(Figure figure)
        {
            int x = 0;
            int y = 0;
            char sym = 'O';

            bool coordsOfSnakesTailAndSnakesFoodAreSame = false;

            while (!coordsOfSnakesTailAndSnakesFoodAreSame)
            {
                x = rnd.Next(2, _mapWeigth - 2);
                y = rnd.Next(2, _mapHight - 2);

                Point foodPoint = new Point(x, y, sym);
                if (figure.IsHit(foodPoint))
                {
                    coordsOfSnakesTailAndSnakesFoodAreSame = false;
                }
                else
                {
                    coordsOfSnakesTailAndSnakesFoodAreSame = true;
                }
            }

            _x = x;
            _y = y;
            _sym = sym;
            return new Point(_x, _y, _sym);
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(_x, _y);
            Console.Write(_sym);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
