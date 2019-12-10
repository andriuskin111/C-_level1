using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3blynas
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameCount = 0;
            string vardas = "";
            while (vardas != "stop")
            {
                Console.WriteLine("Iveskite savo varda: ");
                vardas = Console.ReadLine();
                nameCount++;
                Console.WriteLine("Sveiki {0} [ENTER - testi]", vardas);
                Console.WriteLine("Vardu skaicius: {0}", nameCount);
            }
            Console.Clear();
            Console.WriteLine("ate...");
            Console.ReadLine();
        }
    }
}
