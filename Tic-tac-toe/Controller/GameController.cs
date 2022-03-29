using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_tac_toe.Logic;

namespace Tic_tac_toe.Controller
{
    public class GameController
    {
        IGameControl control;

        public GameController(IGameControl control)
        {
            this.control = control;
        }

        public void MouseLeftDown(int i, int j)
        {
            control.Place(i, j);
        }
    }
}
