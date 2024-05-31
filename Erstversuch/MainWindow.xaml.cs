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
using System.Windows.Threading;

namespace Erstversuch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer AnimationTimer = new DispatcherTimer();
        private DispatcherTimer PlayerTimer = new DispatcherTimer();
        int x, y;
        int dx = 5;
        int dy = 5;
        bool p1up, p1down, p2up, p2down;
        int p1punkte, p2punkte;
        public MainWindow()
        {
            InitializeComponent();
            AnimationTimer.Interval = TimeSpan.FromSeconds(0.03);
            AnimationTimer.Tick += Animate;
            AnimationTimer.Start();

            PlayerTimer.Interval = TimeSpan.FromSeconds(0.03);
            PlayerTimer.Tick += MovePlayer;
            PlayerTimer.Start();

            x = 150;
            y = 150;
            
        }

        private void MovePlayer(object? sender, EventArgs e)
        {
            if (p1down)
            {
                Canvas.SetTop(PaddleLinks, Canvas.GetTop(PaddleLinks)+10);
            }
            if (p1up)
            {
                Canvas.SetTop(PaddleLinks, Canvas.GetTop(PaddleLinks)-10);
            }

            if (p2down)
            {
                Canvas.SetTop(PaddleRechts, Canvas.GetTop(PaddleRechts) + 10);
            }
            if (p2up)
            {
                Canvas.SetTop(PaddleRechts, Canvas.GetTop(PaddleRechts) - 10);
            }
        }

        private void Spielfeld_KeyDown(object sender, KeyEventArgs e)
        {

        }

        public void Window_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    {
                        p1up = true;
                        p1down = false;
                        break;
                    }

                case Key.S:
                    {
                        p1up = false;
                        p1down = true;
                        break;
                    }
                
                case Key.Up:
                    {
                        p2up = true;
                        p2down = false;
                        break;
                    }

                case Key.Down:
                    {
                        p2up = false;
                        p2down = true;
                        break;
                    }
            }
        }

        public void Window_KeyUp(object? sender, KeyEventArgs e)
        {
            p1down = false ;
            p1up = false ;
            p2down = false;
            p2up = false;
        }

        private void Animate(object sender, EventArgs e)
        {
            if (x < 0)
            {
                dx *= -1;
                p2punkte++;
            }
            else if (x + Ball.Width > Spielfeld.ActualWidth)
            {
                dx *= -1;
                p1punkte++;
            }
            
            if (y < 0 || y + Ball.Height > Spielfeld.ActualHeight) dy *= -1;

            //Collision with paddle
            if (x < 0+PaddleLinks.Width &&)



            x += dx;
            y += dy;
            Canvas.SetLeft(Ball, x);
            Canvas.SetTop(Ball, y);
            LabelPlayer1Punkte.Content = p1punkte;
            LabelPlayer2Punkte.Content = p2punkte;
        }


    }
}
