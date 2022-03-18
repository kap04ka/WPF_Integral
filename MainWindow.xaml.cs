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

using WPF_Integral.Classes;

namespace WPF_Integral
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetData()
        {
            double xStart = Convert.ToDouble(start.Text);
            double xEnd = Convert.ToDouble(end.Text);
            double xSteps = Convert.ToDouble(steps.Text);
            ICalculator calc = GetCalculator();
            double result = 0.0;
            result = calc.Calculate(xSteps, xStart, xEnd, x => (7 * x - Math.Log(7 * x) + 8));
            MessageBox.Show("Result is " + Convert.ToString(result), "Result", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private ICalculator GetCalculator()
        {
            switch (method.SelectedIndex)
            {
                case 0:
                    return new MiddleRect();
                case 1:
                    return new Trapeze();
                default:
                    throw new NotImplementedException();
            }
        }

        private void Calc(object sender, RoutedEventArgs e)
        {
            GetData();
        }

        private void DrawGraph(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Component is unfinished!", "Unavailable", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
    }
}
