﻿//26. Write a program in C# Sharp to accept a grade and declare the equivalent description :
//Grade         :- Description :-
//E                Excellent
//V                Very Good
//G                  Good
//A                Average
//F                 Fail

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class pro26
{
    static void Main(string[] args)
    {
        string notes;
        char grd;
        Console.Write("\n\n");
        Console.Write("Accept a grade and display equivalent description:\n");
        Console.Write("---------------------------------------------------");
        Console.Write("\n\n");


        Console.Write("Input the grade :");
        grd = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (grd)
        {
            case 'E':
                notes = " Excellent";
                break;
            case 'V':
                notes = " Very Good";
                break;
            case 'G':
                notes = " Good ";
                break;
            case 'A':
                notes = " Average";
                break;
            case 'F':
                notes = " Fails";
                break;
            default:
                notes = "Invalid Grade Found.";
                break;
        }
        Console.Write("You have chosen  : {0}\n", notes);
    }
}
