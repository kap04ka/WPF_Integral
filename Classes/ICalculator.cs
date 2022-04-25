using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Integral.Classes
{
    public interface ICalculator
    {
        // For parallel steps need be int
        public double Calculate(int steps, double start, double end, Func<double, double> func, out double t);
    }
}
