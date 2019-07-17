using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRigth, int y, char sym)
        {
            _pointsList = new List<Point>();

            for (xLeft = 0; xLeft <= xRigth; xLeft++)
            {
                Point point = new Point(xLeft, y, sym);
                _pointsList.Add(point);
            }
        }
    }
}
