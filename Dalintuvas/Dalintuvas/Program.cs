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
            Console.WriteLine("iveskite veiksma [+ - / *] arba exit");
            veiksmas = Console.ReadLine();

                switch (veiksmas)
                {
                    case "+":
                        rezultatas = a + b;
                        RodytiRezultata(rezultatas);
                        break;
                    case "-":
                        rezultatas = a - b;
                        RodytiRezultata(rezultatas);
                        break;
                    case "/":
                        rezultatas = a / b;
                        RodytiRezultata(rezultatas);
                        break;
                    case "*":
                        rezultatas = a * b;
                        RodytiRezultata(rezultatas);
                        break;
                    case "exit":
                        Console.WriteLine("viso gero!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("neteisingai ivestas veiksmas, pakartokite");
                        break;
                }

            }
                 void RodytiRezultata(double aRezultatas)
            {
                Console.WriteLine("Resultatas yra: {0} ", aRezultatas);
            }
        }
    }
}
