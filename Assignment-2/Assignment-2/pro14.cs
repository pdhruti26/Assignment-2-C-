//14. Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
using System;
public class pro14
{
    public static void Main()
    {
        int vote_age;
        Console.Write("\n\n");
        Console.Write("Detrermine a specific age is eligible for casting the vote:\n");
        Console.Write("----------------------------------------------------------");
        Console.Write("\n\n");


        Console.Write("Input the age of the candidate : ");
        vote_age = Convert.ToInt32(Console.ReadLine());
        if (vote_age < 18)
        {
            Console.Write("Sorry, You are not eligible to caste your vote.\n");
            Console.Write("You would be able to caste your vote after {0} year.\n\n", 18 - vote_age);
        }
        else
            Console.Write("Congratulation! You are eligible for casting your vote.\n\n");
    }
}