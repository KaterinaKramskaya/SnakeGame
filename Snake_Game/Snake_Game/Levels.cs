using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class Levels
    {
        public static int ReturnSpeed(int choosedLevel)
        {
            if (choosedLevel == 1)
            {
                int snakeSpeed = 200;
                return snakeSpeed;
            }
            else if (choosedLevel == 2)
            {
                int snakeSpeed = 100;
                return snakeSpeed;
            }
            else if (choosedLevel == 3)
            {
                int snakeSpeed = 50;
                return snakeSpeed;
            }
            else if (choosedLevel == 4)
            {
                int snakeSpeed = 25;
                return snakeSpeed;
            }
            return 100;
        }

    }
}
