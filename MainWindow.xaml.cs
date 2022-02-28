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

namespace WPF_Integral
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("\tInput:\nStart: "+start.Text+";\nEnd: "+end.Text+";\nSteps: "+steps.Text+";\nMethod: "+method.Text+".", "Info",MessageBoxButton.OK,MessageBoxImage.Asterisk);
        }

        private void DrawGraph(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Component is unfinished!", "Unavailable", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
    }
}
