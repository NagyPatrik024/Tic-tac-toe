using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Tic_tac_toe.Logic;

namespace Tic_tac_toe.Render
{
    public class Display : FrameworkElement
    {
        IGameModel _model;
        Size _size;
        public void Resize(Size size)
        {
            this._size = size;
        }

        public void SetupModel(IGameModel model)
        {
            this._model = model;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            if (_model != null && _size.Width == _size.Height && _size.Width == 3)
            {
                for (int i = 0; i < _model.GameMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < _model.GameMatrix.GetLength(1); j++)
                    {
                        
                    }
                }
            }
        }
    }
}
