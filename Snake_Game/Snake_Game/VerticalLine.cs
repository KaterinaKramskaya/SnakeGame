using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yTop, int yBottom, int x, char sym)
        {
            _pointsList = new List<Point>();

            for (yTop = 0; yTop <= yBottom; yTop++)
            {
                Point point = new Point(x, yTop, sym);
                _pointsList.Add(point);
            }
        }
    }
}
