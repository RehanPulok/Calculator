using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class IScientificCalculator : IBasicCalculator, BasicCalculator
    {
        static int num1, num2, remainder;
        public void Power(double x, double y)
        {
            if (y == 0)
            {
                Result = 0;
            }
           
            for (int i = 1; i < Convert.ToInt32(y); i++)
            {
                Result = Result * i;

            }
        }
        /*
        public void ToBinary(int x)
        {
            while (x > 0)
            {
                remainder = x % 2;
                x /= 2;
                Result = remainder.ToString() + Result;
            }
            Console.WriteLine("Binary:  {0}", Result);
        }
        */

    }
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write Another number: ");
            num2 = int.Parse(Console.ReadLine());
            BasicCalculator bc = new IScientificCalculator();
            bc.Addition(num1,num2);
            bc.Subtraction(num1,num2);
            bc.Division(num1,num2);
            bc.Multiplication(num1,num2);
            bc.Power(num1,num2);

        }
    }
}
    
