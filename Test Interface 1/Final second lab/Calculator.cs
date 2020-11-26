using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_second_lab
{
    class Calculator : CalculatorInterface
    {
        public Calculator()
        {
            Console.WriteLine("calculator.");
        }
        
        public double SquareRoot(double x)
        {
            Console.WriteLine("Square Root : "+ Math.Sqrt(x));
            return Math.Sqrt(x);
        }

        public int XtoY(int x, int y)
        {
            Console.WriteLine("X To Y : " + Convert.ToInt32(Math.Pow(x, y)));
            return Convert.ToInt32(Math.Pow(x, y));
        }

       

        
    }
}
