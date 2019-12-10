using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalintuvas
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double rezultatas;
            string veiksmas = "";
            while (veiksmas != "exit")
            {
            Console.WriteLine("iveskite pirma skaiciu");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("iveskite antra skaiciu");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("iveskite veiksma [+ - / *]");
            veiksmas = Console.ReadLine();
                Console.WriteLine(veiksmas);

            if (veiksmas == "+")
            {
                rezultatas = a + b;
                    Console.WriteLine("Resultatas yra: {0} ", rezultatas);
                }

            if (veiksmas == "-")
            {
                rezultatas = a - b;
                    Console.WriteLine("Resultatas yra: {0} ", rezultatas);
                }

            if (veiksmas == "/")
            {
                rezultatas = a / b;
                    Console.WriteLine("Resultatas yra: {0} ", rezultatas);
                }

            if (veiksmas == "*")
            {
                rezultatas = a * b;
                    Console.WriteLine("Resultatas yra: {0} ", rezultatas);
                }
            else
            {
                Console.WriteLine("Neteisingas veiksmas, iveskite is naujo");
            }
                
            veiksmas = "";
            Console.ReadLine();
            }
        }
    }
}
