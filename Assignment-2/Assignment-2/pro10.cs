﻿//10. Write a C# Sharp program to accept two integers and check whether they are equal or not.

using System;
public class pro10
{
    public static void Main()
    {
        int int1, int2;
        Console.Write("\n\n");
        Console.Write("Check whether two integers are equal or not:\n");
        Console.Write("-------------------------------------------");
        Console.Write("\n\n");
        Console.Write("Input 1st number: ");
        int1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input 2nd number: ");
        int2 = Convert.ToInt32(Console.ReadLine());

        if (int1 == int2)
            Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
        else
            Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);
    }
}
