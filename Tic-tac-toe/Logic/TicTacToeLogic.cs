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
            if (GameMatrix[i,j] != 'X' && GameMatrix[i,j] != 'O')
            {
                GameMatrix[i, j] = 'X';

                int i2 = rnd.Next(0, 3);
                int j2 = rnd.Next(0, 3);


                if (IsThereAnyFreePlace())
                {
                    while (GameMatrix[i2, j2] != 0)
                    {
                        i2 = rnd.Next(0, 3);
                        j2 = rnd.Next(0, 3);
                    }
                    GameMatrix[i2, j2] = 'O';
                }
                
            }
        }

        public bool IsThereAnyFreePlace()
        {
            for (int i = 0; i < GameMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < GameMatrix.GetLength(1); j++)
                {
                    if (GameMatrix[i,j] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        
        }
    }
}
