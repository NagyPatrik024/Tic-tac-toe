using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe.Logic
{
    public class TicTacToeLogic : IGameModel, IGameControl
    {
        public char[,] GameMatrix { get; set; }

        Random rnd = new Random();

        public TicTacToeLogic()
        {
            GameMatrix = new char[3, 3];
        }

        public void Place(int i, int j)
        {
            GameMatrix[i, j] = 'X';

            int i2 = rnd.Next(0, 3);
            int j2 = rnd.Next(0, 3);
            while (GameMatrix[i2, j2] != null)
            {
                i2 = rnd.Next(0, 3);
                j2 = rnd.Next(0, 3);
            }
            GameMatrix[i2, j2] = '0';
        }
    }
}
