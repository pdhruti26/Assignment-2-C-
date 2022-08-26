﻿//22. Write a C# Sharp program to check whether a triangle can be formed by the given value for the angles.

using System;
public class pro22
{
    public static void Main()
    {
        int anga, angb, angc, sum; //are three angles of a triangle  
        Console.Write("\n\n");
        Console.Write("Check whether a triangle can be formed by given value:\n");
        Console.Write("--------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input angle1 of triangle: ");
        anga = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input angle 2 of triangle: ");
        angb = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input angle 3 of triangle: ");
        angc = Convert.ToInt32(Console.ReadLine());

        /* Calculate the sum of all angles of triangle */
        sum = anga + angb + angc;

        /* Check whether sum=180 then its a valid triangle otherwise not */
        if (sum == 180)
        {
            Console.Write("The triangle is valid.\n");
        }
        else
        {
            Console.Write("The triangle is not valid.\n");
        }
    }

}

