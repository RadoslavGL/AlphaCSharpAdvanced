using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sub_stringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string subset = Console.ReadLine();
            string text = Console.ReadLine();

            int count = 0;
            int indexFound = 0;
            int indexNext = 0;

            while (true)
            {
                indexFound = text.IndexOf(subset, indexNext, StringComparison.CurrentCultureIgnoreCase);
                if (indexFound > -1)
                {
                    indexNext = indexFound + 1;
                    count++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }

    }
}
