using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ipod : ");
            Ipod ip1 = new Ipod();

            ip1.Switch(true);
            ip1.Play(true);
            ip1.PlayNext();
            ip1.PlayPrevious();
            ip1.SetVolume(15);

            Console.WriteLine();
            
            Console.WriteLine("Phone : ");
            Phone ph1 = new Phone();

            ph1.Switch(true);
            ph1.Retune(8946.9);
            ph1.SetVolume(19);
            ph1.ChangeChannel();

            Console.WriteLine();
        }
    }
}
