//Write a method that counts how many times given number appears in a given array.
//Write a test program to check if the method is working correctly.
using System;
using System.Collections.Generic;
using System.Linq;
class AppearanceCount
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        int[] numbers = new int[n];
        numbers = input.Split(' ').Select(x => int.Parse(x)).ToArray();

        Console.WriteLine(LargestFrequence(numbers));

    }

    public static int LargestFrequence(int[] numbers)
    {
        int largestFreq = 1;
        int currentFreq = 1;

        Array.Sort(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            int indexIncrement = 1;
            while (((i + indexIncrement) < numbers.Length) && numbers[i] == numbers[i + indexIncrement])
            {
                if (numbers[i] == numbers[i + indexIncrement])
                {
                    currentFreq++;
                    if (currentFreq > largestFreq)
                    {
                        largestFreq = currentFreq;
                    }
                    indexIncrement++;

                }
                else
                {
                    indexIncrement++;
                    if (currentFreq > largestFreq)
                    {
                        largestFreq = currentFreq;
                    }
                }
                
            }
        }

        return largestFreq;
    }
}

