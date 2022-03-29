using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe.Logic
{
    public interface IGameModel
    {
        char[,] GameMatrix { get; set; }
    }
}
