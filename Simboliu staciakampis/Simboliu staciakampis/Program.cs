using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simboliu_staciakampis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite simboli");
            string simbolis = Console.ReadLine();
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.WriteLine("{0} {0}", simbolis);
            Console.WriteLine("{0} {0}", simbolis);
            Console.WriteLine("{0} {0}", simbolis);
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.ReadLine();
        }
    }
}
