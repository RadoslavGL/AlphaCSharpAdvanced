using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        //start - 1 or the previous number, end - current number
        public static int ReadNumber(int start, int end)
        {
            if (end > start && end < 100)
            {
                return end;

            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10];

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int input = int.Parse(Console.ReadLine());
                    int start = 1;

                    if (i != 0)
                    {
                        start = arr[i - 1];
                    }

                    arr[i] = ReadNumber(start, input);

                }
                Console.WriteLine("1 < {0} < 100", string.Join(" < ", arr));

            }
            catch (FormatException)
            {
                Console.WriteLine("Exception");
                //throw;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Exception");
            }


        }
    }
}
