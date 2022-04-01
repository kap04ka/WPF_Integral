using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Integral.Classes
{
    public interface ICalculator
    {
        public double Calculate(double steps, double start, double end, Func<double, double> func, out double t);
    }
}
