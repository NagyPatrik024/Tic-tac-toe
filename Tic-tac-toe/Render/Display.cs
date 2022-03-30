using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
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
            if (_model != null && _size.Width > 50 && _size.Height > 50)
            {
                double rectWidth = _size.Width / _model.GameMatrix.GetLength(1);
                double rectHeight = _size.Height / _model.GameMatrix.GetLength(0);


                for (int i = 0; i < _model.GameMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < _model.GameMatrix.GetLength(1); j++)
                    {
                        ImageBrush brush = new ImageBrush();
                        switch (_model.GameMatrix[i, j])
                        {
                            case 'X':
                                brush = new ImageBrush(new BitmapImage(new Uri(Path.Combine("Images", "x.png"), UriKind.RelativeOrAbsolute)));
                                break;
                            case 'O':
                                brush = new ImageBrush(new BitmapImage(new Uri(Path.Combine("Images", "o.png"), UriKind.RelativeOrAbsolute)));
                                break;
                            default:                     
                                break;
                        }

                        drawingContext.DrawRectangle(brush
                                    , new Pen(Brushes.Black, 4),
                                    new Rect(j * rectWidth, i * rectHeight, rectWidth, rectHeight)
                                    );
                    }
                }

            }
        }
    }
}
