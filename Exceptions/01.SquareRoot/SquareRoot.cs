using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class SquareRoot
    {

        public static double Sqrt(double input)
        {
           
            if (input < 0)
            {
                    
            }
           
            double output = Math.Sqrt(input);
            return output;
        }

        static void Main(string[] args)
        {

            try
            {
                double input = double.Parse(Console.ReadLine());

                try
                {
                    Console.WriteLine("{0:f3}", Sqrt(input));

                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Invalid number");
                    //throw;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
                //throw;
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
