using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tic_tac_toe.Controller;
using Tic_tac_toe.Logic;

namespace Tic_tac_toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameController _controller;
        public MainWindow()
        {
            InitializeComponent();
            TicTacToeLogic logic = new TicTacToeLogic();
            display.SetupModel(logic);
            _controller = new GameController(logic);

        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            display.Resize(new Size(grid.ActualWidth, grid.ActualHeight));
            display.InvalidateVisual();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            display.Resize(new Size(grid.ActualWidth, grid.ActualHeight));
            display.InvalidateVisual();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var p = e.GetPosition(this);
            int x = 0;
            int y = 0;
            double segedx = ActualWidth / 3;
            double segedy = ActualHeight / 3;
            if (p.X <= segedx)
            {
                x = 0;
            }
            else if (p.X >= segedx && p.X <= (ActualWidth * 0.66))
            {
                x = 1;
            }
            else if(p.X >= segedx * 0.66)
            {
                x = 2;
            }

            if (p.Y <= segedy)
            {
                y = 0;
            }
            else if (p.Y >= segedy && p.Y <= ActualHeight * 0.66)
            {
                y = 1;
            }
            else if (p.Y >= segedy * 0.66)
            {
                y = 2;
            }
            _controller.MouseLeftDown(y,x);
            display.InvalidateVisual();
        }
    }
}
