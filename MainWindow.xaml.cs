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

namespace FlyBodyInSky
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Line myLine;
        private Point position;
        private Point cannon = new Point(40,140);
        private double distance;
        private double velocity = 100;
        private double angle = 45;
        private double time;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Canvas1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Canvas1.Children.Clear();
            time = 0;

            position = Mouse.GetPosition(Canvas1);

            myLine = new Line()
            {
                X1 = cannon.X - 2.5f,
                Y1 = cannon.Y - 2.5f,
                X2 = cannon.X + 2.5f,
                Y2 = cannon.Y + 2.5f,
                Stroke = Brushes.Blue,
                StrokeThickness = 7.5f,
            };
            Canvas1.Children.Add(myLine);

            myLine = new Line()
            {
                X1 = position.X-2.5f,
                Y1 = cannon.Y - 2.5f,
                X2 = position.X+2.5f,
                Y2 = cannon.Y + 2.5f,
                Stroke = Brushes.Red,
                StrokeThickness = 7.5f,
            };
            Canvas1.Children.Add(myLine);


            for (int i = 1; i < 1000; i++)
            {
                velocity = i;
                if(Calculate() == true)
                {
                    label1.Content = "Угол: " + (int) (angle * 60) + " град";
                    label2.Content = "Скорость: " + velocity + " м/с";
                    label3.Content = "Дистанция: " + distance + " м";
                    label4.Content = "Время полета: " + (int) time + " с";
                    break;
                }
            }

        }

        private bool Calculate()
        {
            distance = (int) Math.Abs(Math.Sqrt(Math.Pow(position.X - cannon.X, 2)));
            angle = Math.Asin((distance * 9.8f) / Math.Pow(velocity, 2));
            angle = angle / 2;
            double x = 0;
            double y = 0;

            var vx = velocity * Math.Cos(angle);
            var vy = velocity * Math.Sin(angle);
            var dt = distance / velocity / 1000;
            var g = 9.8;

            if (vx < 0.00001) return false;
            while (x < distance)
            {
                time += dt;
                vy -= g * dt;
                x += vx * dt;
                y += vy * dt;
                if (Double.IsNaN(x)|| Double.IsNaN(y)) continue;
                DrawPoint(x, y);
            }

            return Math.Abs(y) <= distance / 100;
        }

        private void DrawPoint(double x, double y)
        {
            myLine = new Line()
            {
                X1 = (int) cannon.X + x - .5f,
                Y1 = (int) cannon.Y - y - .5f,
                X2 = (int) cannon.X + x + .5f,
                Y2 = (int) cannon.Y - y + .5f,
                Stroke = Brushes.LightCyan,
                StrokeThickness = 2,
            };
            Canvas1.Children.Add(myLine);
        }
    }
}
