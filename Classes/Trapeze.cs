using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WPF_Integral.Classes
{
    class Trapeze : ICalculator
    {
        public double Calculate(double steps, double start, double end, Func<double, double> func, out double t)
        {
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

            return sum;
        }
    }
}
