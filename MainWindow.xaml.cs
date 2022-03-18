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
using OxyPlot;
using OxyPlot.Series;

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

            double timeElapsed = 0;
            result = calc.Calculate(xSteps, xStart, xEnd, x => (7 * x - Math.Log(7 * x) + 8), out timeElapsed);
            MessageBox.Show("Result is " + Convert.ToString(result) + ";\nTime: " + Convert.ToString(timeElapsed) + " ms.", "Result", MessageBoxButton.OK, MessageBoxImage.Asterisk);
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
            PlotModel plotModel = new PlotModel()
            {
                Title = "7x - ln(7x) + 8",
            };

            LineSeries Series = new LineSeries();

            int MaxGragphSteps = 10000;
            double xStart = Convert.ToDouble(start.Text);
            double xEnd = Convert.ToDouble(end.Text);
            ICalculator calc = GetCalculator();

            for (int i = 0; i < MaxGragphSteps; i++)
            {
                double t = 0;
                double result = calc.Calculate(i, xStart, xEnd, x => (7*x - Math.Log(7*x)+8), out t);
                Series.Points.Add(new DataPoint(i, t));
            }

            plotModel.Series.Add(Series);
            Graphics.Model = plotModel;
        }
    }
}
