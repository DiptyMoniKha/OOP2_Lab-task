using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Saving("dipty", "10101", 900);
            a1.ShowInfo();
            a1.Deposit(10101);
            a1.Withdraw(1256);
            a1.ShowInfo();
            Console.WriteLine();
            
            Account a2 = new Fixed("dip", "56544", 6500, 45, 2020);
            a2.ShowInfo();
            a2.Deposit(500);
            a2.Withdraw(6520);
            a2.ShowInfo();

        }
    }
}
