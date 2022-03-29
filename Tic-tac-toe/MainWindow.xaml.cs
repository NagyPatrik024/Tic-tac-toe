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
            _controller.MouseLeftDown((int)Math.Floor(e.GetPosition(this).Y / 100),(int)Math.Floor(e.GetPosition(this).X / 100));
            display.InvalidateVisual();
        }
    }
}
