using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SayHELLo
{
    class SayHELLo
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            SaysHello(name);
        }
        public static void SaysHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
