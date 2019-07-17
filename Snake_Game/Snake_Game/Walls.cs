using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class Walls
    {
        private List<Figure> _wallList;

        public Walls(int mapWigth, int mapHeight)
        {

            HorizontalLine topLine = new HorizontalLine(0, mapWigth - 2, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, mapWigth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rigthLine = new VerticalLine(0, mapHeight - 1, mapWigth - 2, '+');

            _wallList = new List<Figure>();
            _wallList.Add(topLine);
            _wallList.Add(bottomLine);
            _wallList.Add(leftLine);
            _wallList.Add(rigthLine);
        }

        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (Figure wall in _wallList)
            {
                wall.Draw();
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public bool IsHit(Figure figure)
        {
            foreach (var wall in _wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }               
            }
            return false;
        }

    }
}
