using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WPF_Integral.Classes
{
    class MiddleRect : ICalculator
    {
        public double Calculate(double steps, double start, double end, Func<double, double> func, out double t)
        {
            Stopwatch sw = new Stopwatch();
            double h = (end - start) / steps;
            double sum = 0;

            sw.Start();
            for (int i = 1; i <= steps; i++) // <= ?
            {
                sum += h*func(start + h * i - 0.5*h);
            }

            sw.Stop();
            TimeSpan time = sw.Elapsed;
            t = time.TotalMilliseconds;

            return sum;
        }
    }
}
