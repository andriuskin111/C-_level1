using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triju_skaiciu_manipuliacijos
{
    class Program
    {
        static void Main(string[] args)
        {
            double rez1;
            double rez2;

            Console.WriteLine("Iveskite skaiciu A");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu B");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu C");
            double C = Convert.ToDouble(Console.ReadLine());

            rez1 = (A + B) * C;
            rez2 = A * C + B * C;

            Console.WriteLine("(A + B) * C = {0}", rez1);
            Console.WriteLine("A * C + B * C = {0}", rez2);
            Console.ReadLine();
        }
    }
}
