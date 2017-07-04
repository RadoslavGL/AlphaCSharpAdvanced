using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        //string reversed = "";

        //for (int i = input.Length - 1; i > -1 ; i--)
        //{
        //    reversed += input[i];
        //}

        //Console.WriteLine(reversed);

        //char[] reversedInput = input.Reverse().ToArray();
        //Console.WriteLine(string.Join("", reversedInput));

        string output = new string(input.Reverse().ToArray());
        Console.WriteLine(output);
    }
}

