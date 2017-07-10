using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    class Demo
    {
        static void Main(string[] args)
        {
            try
            { 
                var exception = new ArgumentException("My inner exception");

                throw new NullReferenceException("Custom message", exception);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.InnerException);
            }

            
        }
    }
}
