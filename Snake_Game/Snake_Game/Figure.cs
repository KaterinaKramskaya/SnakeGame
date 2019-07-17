using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class Figure
    {
        internal List<Point> _pointsList;

        public virtual void Draw()
        {
            foreach (Point point in _pointsList)
            {
                point.Draw();
            }
        }

        public bool IsHit(Point point)
        {
            foreach (Point p in _pointsList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsHit(Figure figure)
        {
            foreach (Point p in _pointsList)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
