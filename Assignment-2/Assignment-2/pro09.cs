﻿//9. Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.
using System;
public class pro9
{
    public static void Main()
    {
        string answer;
        string result;

        Console.Write("Input a Number : ");
        answer = Console.ReadLine();

        int num = Convert.ToInt32(answer);
        result = "";
        while (num > 1)
        {
            int remainder = num % 2;
            result = Convert.ToString(remainder) + result;
            num /= 2;
        }
        result = Convert.ToString(num) + result;
        Console.WriteLine("Binary: {0}", result);
    }
}


