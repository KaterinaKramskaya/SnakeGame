using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class Point
    {
        protected int _x;
        protected int _y;
        internal char _sym;

        public Point()
        {

        }

        public Point(Point point)
        {
            _x = point._x;
            _y = point._y;
            _sym = point._sym;
        }

        public Point(int x, int y, char sym)
        {
            _x = x;
            _y = y;
            _sym = sym;
        }

        public void Move(int offsetOfPoint, Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    _y -= offsetOfPoint;
                    break;
                case Direction.Down:
                    _y += offsetOfPoint;
                    break;
                case Direction.Left:
                    _x -= offsetOfPoint;
                    break;
                case Direction.Right:
                    _x += offsetOfPoint;
                    break;

                default:
                    break;
            }
        }

        public void Clear()
        {
            _sym = ' ';
            Draw();
        }

        public virtual void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(_sym);
        }

        public bool IsHit(Point point)
        {
            return _x == point._x && _y == point._y;
        }
    }
}
