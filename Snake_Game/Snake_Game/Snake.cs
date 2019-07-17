using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake_Game
{
    class Snake : Figure
    {
        private Direction _direction;

        public Snake(Point tail, int length, Direction direction)
        {
            _direction = direction;
            _pointsList = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                Point snakePoint = new Point(tail);
                snakePoint.Move(i, direction);
                _pointsList.Add(snakePoint);
            }
        }

        public void Move()
        {
            Point tail = _pointsList.First();
            _pointsList.Remove(tail);
            Point head = GetNextPoint();
            _pointsList.Add(head);

            tail.Clear();
            head.Draw();
        }

        internal bool IsHitWithTail()
        {
            Point head = _pointsList.Last();

            for (int i = 0; i < _pointsList.Count - 2; i++)
            {
                if (head.IsHit(_pointsList[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public Point GetNextPoint()
        {
            Point head = _pointsList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, _direction);
            return nextPoint;
        }

        public void EnteredKey(ConsoleKeyInfo enteredKey)
        {
            switch (enteredKey.Key)
            {
                case ConsoleKey.UpArrow:
                    _direction = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    _direction = Direction.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    _direction = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    _direction = Direction.Right;
                    break;
            }
        }

        public bool Eat(Point foodForSnake)
        {
            Point head = GetNextPoint();
            if (head.IsHit(foodForSnake))
            {
                foodForSnake._sym = head._sym;
                _pointsList.Add(foodForSnake);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
