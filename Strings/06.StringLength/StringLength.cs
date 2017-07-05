using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);

            if (input.Length < 20)
            {
                Console.WriteLine("{0}", input.PadRight(20, '*'));
            }
            else
            {
                Console.WriteLine(input);
            }

        }
    }
}
