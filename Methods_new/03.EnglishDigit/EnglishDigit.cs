//Write a method that returns the last digit of given integer as an English word.
//Write a program that reads a number and prints the result of the method.

using System;
using System.Collections.Generic;
using System.Linq;

class EnglishDigit
{
    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(LastDigitWord(number));
    }

    public static string LastDigitWord(int number)
    {
        string word = "";

        int lastDigit = number % 10;

        switch (lastDigit)
        {
            case 0: word = "zero"; break;
            case 1: word = "one"; break;
            case 2: word = "two"; break;
            case 3: word = "three"; break;
            case 4: word = "four"; break;
            case 5: word = "five"; break;
            case 6: word = "six"; break;
            case 7: word = "seven"; break;
            case 8: word = "eight"; break;
            case 9: word = "nine"; break;
            default:
                break;
        }

        return word;

    }
}

