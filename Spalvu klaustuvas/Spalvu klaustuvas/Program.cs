using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spalvu_klaustuvas
{
    class Program
    {
        static void Main(string[] args)
        {   
            int klausimuSkaicius = 1;
            string spalva = "";
            while(spalva != "exit")
            {
                Console.WriteLine("Klausimas Nr {0}", klausimuSkaicius);
                Console.WriteLine("Kokia tavo megstamiausia spalva?");
                spalva = Console.ReadLine();
                klausimuSkaicius ++;
                Console.WriteLine("Mano irgi:) [Baigti zaidima - exit]");
                Console.WriteLine();
                
            }
        }
    }
}
