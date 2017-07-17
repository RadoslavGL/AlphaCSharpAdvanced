//http://bgcoder.com/Contests/Practice/Index/392#0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.SecretNumeralSystem
{
    class SecretNumeralSystem
    {
        public static void Main(string[] args)
        {
            string[] digits = { "hristo", "tosho", "pesho",
                "hristofor", "vlad", "haralampi", "zoro", "vladimir" };

            string input = Console.ReadLine();
            StringBuilder sbInput = new StringBuilder(input);

            for (int i = digits.Length - 1; i > -1 ; i--)
            {
                sbInput.Replace(digits[i], i.ToString());
            }

            char[] separators = new char[] { ',', ' ' };

            string[] inputArr = (sbInput.ToString()).Split(separators, StringSplitOptions.RemoveEmptyEntries);

            ulong[] numbers = new ulong[4];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ConverToDecimal(inputArr[i], 8);
            }

            BigInteger result = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }

            Console.WriteLine(result);
        }

        public static ulong ConverToDecimal(string n, ushort b)
        {
            ulong result = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int digit = 0;
                if (n[i] >= '0' && n[i] <= '9')
                {
                    digit = n[i] - '0';
                }
                else
                {
                    digit = n[i] - 'A' + 10;
                }

                result = result * b + (uint)digit;

            }

            return result;
        }
    }
}
