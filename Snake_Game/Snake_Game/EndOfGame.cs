using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class EndOfGame
    {
        private string _resultOfGame;

        public void EndGameResult(Figure figure, int mapWeidth, int mapHeight)
        {
            if (figure._pointsList.Count == ((mapWeidth - 1) * (mapHeight - 1)))
            {
                _resultOfGame = "W I N N E R";
            }
            else
            {
                _resultOfGame = "Y O U    L O S E";
            }
        }

        public void DrawEndGameResult()
        {
            int xOffset = 28;
            int yOffset = 9;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("--------------------", xOffset, yOffset++);
            WriteText("G A M E    O V E R", xOffset + 1, yOffset++);
            yOffset++;
            WriteText(_resultOfGame, xOffset + 2, yOffset++);
            WriteText("--------------------", xOffset, yOffset++);
        }

        public void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
