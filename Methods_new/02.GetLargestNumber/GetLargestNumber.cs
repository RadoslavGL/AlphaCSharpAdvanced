//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
class GetLargestNumber
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int[] numInput = input.Split(' ').Select(x => int.Parse(x)).ToArray();

        Console.WriteLine(MaxValue(MaxValue(numInput[0], numInput[1]), numInput[2]));

    }

    public static int MaxValue(int num1, int num2)
    {
        return num1 > num2 ? num1 : num2;
    }
}

