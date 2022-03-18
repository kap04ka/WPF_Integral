using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Integral.Classes
{
    class Trapeze : ICalculator
    {
        public double Calculate(double steps, double start, double end, Func<double, double> func)
        {
            double h = (end - start) / steps;
            double sum = 0;
            for (int i = 0; i < steps; i++)
            {
                sum += func(start + h * i); //Где умножать на h?
            }
            sum += (func(start) + func(end)) / 2;
            sum *= h;
            return sum;
        }
    }
}
