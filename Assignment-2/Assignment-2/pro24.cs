﻿//24. Write a C# Sharp program to calculate profit and loss on a transaction.

using System;
public class pro24
{
    public static void Main()
    {
        int cprice, sprice, plamt;

        Console.Write("\n\n");
        Console.Write("Calculate profit and loss:\n");
        Console.Write("----------------------------");
        Console.Write("\n\n");


        Console.Write("Input Cost Price: ");
        cprice = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Selling Price: ");
        sprice = Convert.ToInt32(Console.ReadLine());

        if (sprice > cprice)
        {
            plamt = sprice - cprice;
            Console.Write("\nYou can booked your profit amount : {0}\n", plamt);
        }
        else if (cprice > sprice)
        {
            plamt = cprice - sprice;
            Console.Write("\nYou got a loss of amount : {0}\n", plamt);
        }
        else
        {
            Console.Write("\nYou are running in no profit no loss condition.\n");
        }
    }
}
