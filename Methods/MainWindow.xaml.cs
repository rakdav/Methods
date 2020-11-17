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

namespace Methods
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double ta = double.Parse(a.Text);
                double tb = double.Parse(b.Text);
                double tc = double.Parse(c.Text);
                Result.Text = "Площадь треугольника:" + String.Format("{0:F2}",S(ta,tb,tc))+Environment.NewLine;
                double Radius = double.Parse(R.Text);
                Result.Text += "Площадь окружности:" + String.Format("{0:F2}", S(Radius)) + Environment.NewLine;
                double ra = double.Parse(osn.Text);
                double rb = double.Parse(H.Text);
                Result.Text += "Площадь прямоугольника:" + String.Format("{0:F2}", S(ra,rb)) + Environment.NewLine;
                Fine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double S(double x,double y)
        {
            return x * y;
        }
        private double S(double R)
        {
            return Math.PI * R * R;
        }

        private double S(double x,double y,double z)
        {
            double pp = (x + y + z) / 2;
            return Math.Sqrt(pp * (pp-x) * (pp-y) * (pp-z));
        }
        private void Fine()
        {
            Result.Text += "Программа закончена";
        }
    }
}
