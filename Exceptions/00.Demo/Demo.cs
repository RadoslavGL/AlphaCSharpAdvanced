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
            //try
            //{
            //    var exception = new ArgumentException("My inner exception");

            //    throw new NullReferenceException("Custom message", exception);
            //}
            //catch (NullReferenceException e)
            //{
            //    Console.WriteLine(e.InnerException);
            //}

            //try
            //{
            //    int a = 5;
            //    int b = a / 0; // Exception
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Executed always");
            //}


            //try
            //{
            //    throw new StackOverflowException("Custom message");
            //}
            //catch (StackOverflowException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //inner exception and custom message
            //try
            //{
            //    var exception = new ArgumentException("My inner exception");

            //    throw new NullReferenceException("Message: ", exception);
            //}
            //catch (NullReferenceException e)
            //{
            //    Console.WriteLine(e.InnerException);
            //}

            //rethrow
            //try
            //{
            //    int.Parse("str");
            //}
            //catch (FormatException fe)
            //{
            //    Console.WriteLine("Parse failed!");
            //    throw fe; // Re-throw the caught exception
            //}

            //DEMO

            try
            {
                Sqrt(-1);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine("Error: {0}", ex.Message);
                //throw;
            }


        }


        public static double Sqrt(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Sqrt for negative numbers is undefined!");
            }

            return Math.Sqrt(value);
        }


    }
}
