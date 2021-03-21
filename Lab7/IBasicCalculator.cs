using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class IBasicCalculator : BasicCalculator
    {
        private double x;
        private double y;
        private double result;

        public double Result
        {
            get { return result; }
            set { result = value; }
        }


        public double Y
        {
            get { return y; }
            set { y = value; }
        }


        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public IBasicCalculator(double x, double y)
        {
            this.x = X;
            this.y = Y;
        }
        public IBasicCalculator()
        { }
        public void Addition(double x, double y)
        {
            result = x + y;
            Console.WriteLine("Addition result: ",result);
            
        }
        public void Subtraction(double x, double y)
        {
            result = x - y;
            Console.WriteLine("Subtraction result: ", result);

        }
        public void Division(double x, double y)
        {
            try {
                result = x / y;
                Console.WriteLine("Addition result: ", result);
            }
            
            
                catch (DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero.", x);
            }
        
        }
        public void Multiplication(double x, double y)
        {
            result = x * y;
            Console.WriteLine("Multiplication result: ", result);
        }
    }
}
