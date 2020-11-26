using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_second_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalCalculator n1 = new NormalCalculator();
            n1.sum(10, 20);
            n1.sub(40, 20);
            n1.multiplication(15, 10);
            n1.division(100, 20);
            Console.WriteLine();
            ScientificCalculator s1 = new ScientificCalculator();
            s1.XtoY(5, 10);
            s1.SquareRoot(8);
            
        }
    }
}
