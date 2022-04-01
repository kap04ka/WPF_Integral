using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WPF_Integral.Classes
{
    public class Trapeze : ICalculator
    {
        public double Calculate(double steps, double start, double end, Func<double, double> func, out double t)
        {
            if (steps <= 0) throw new ArgumentException("Incorrect input (steps must be >=1)");
            bool messedLims = false;
            if (start > end)
            {
                messedLims = true;
                double tmp = start;
                start = end;
                end = tmp;
            }

            Stopwatch sw = new Stopwatch();

            double h = (end - start) / steps;
            double sum = 0;

            sw.Start();
            for (int i = 0; i < steps; i++)
            {
                sum += func(start + h * i); //Где умножать на h?
            }
            sum += (func(start) + func(end)) / 2;
            sum *= h;
            sw.Stop();

            TimeSpan time = sw.Elapsed;
            t = time.TotalMilliseconds;

            if (messedLims) sum *= -1.0;
            return sum;
        }
    }
}
