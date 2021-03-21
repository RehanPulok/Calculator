using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    interface BasicCalculator
    {
        void Addition(double x, double y);
        void Subtraction(double x, double y);
        void Division(double x, double y);
        void Multiplication(double x, double y);
        void Power(double x, double y);
    }
}
