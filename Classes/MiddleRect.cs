using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Integral.Classes
{
    class MiddleRect : ICalculator
    {
        public double Calculate(double steps, double start, double end, Func<double, double> func)
        {
            double h = (end - start) / steps;
            double sum = 0;
            for (int i = 1; i <= steps; i++) // <= ?
            {
                sum += h*func(start + h * i - 0.5*h);
            }
            return sum;
        }
    }
}
