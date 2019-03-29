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

namespace T_Shirt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            



            Rectangle rb = new Rectangle();
            rb.Fill = Brushes.LightBlue;
            rb.Width = (400);
            rb.Height = (500);
            Canvas.SetLeft(rb, 300);
            Canvas.SetTop(rb, 100);
            canvas.Children.Add(rb);
            Ellipse hh = new Ellipse();
            hh.Height = 200;
            hh.Width = 200;
            Canvas.SetLeft(hh, 400);
            hh.Fill = Brushes.White;
            canvas.Children.Add(hh);

        }


        private void PolkaDotsBox_Checked(object sender, RoutedEventArgs e)
        {
            for (int j = 3; j < 7; j++)
            {
                for (int i = 2; i < 6; i++)
                {
                    Ellipse w = new Ellipse();
                    w.Height = 50;
                    w.Width = 50;
                    w.Fill = Brushes.Green;
                    Canvas.SetTop(w, i * 105);
                    Canvas.SetLeft(w, j * 105);
                    canvas.Children.Add(w);
                }
            }
        }

        private void PolkaDotsBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Rectangle rb = new Rectangle();
            rb.Fill = Brushes.LightBlue;
            rb.Width = (400);
            rb.Height = (500);
            Canvas.SetLeft(rb, 300);
            Canvas.SetTop(rb, 100);
            canvas.Children.Add(rb);
            Ellipse hh = new Ellipse();
            hh.Height = 200;
            hh.Width = 200;
            Canvas.SetLeft(hh, 400);
            hh.Fill = Brushes.White;
            canvas.Children.Add(hh);
        }
    }
}
