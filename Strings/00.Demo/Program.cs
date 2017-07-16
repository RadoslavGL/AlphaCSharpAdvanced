using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, Telerik Academy";
            string text1 = "Hello, Telerik Academy";

            Console.WriteLine(Object.ReferenceEquals(text, text1));

            text1 += "!";

            text.IndexOfAny()

            // text1 no longer points to the same memory as text
            Console.WriteLine(Object.ReferenceEquals(text, text1));
        }
    }
}
