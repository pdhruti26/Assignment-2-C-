//1.	Write a C# Sharp program that takes three letters as input and display them in reverse order.

using System;
 class pro1
{
    static void Main()
    {
        char letter, letter1, letter2;

        Console.Write("Input letter: ");
        letter = Convert.ToChar(Console.ReadLine());

        Console.Write("Input letter: ");
        letter1 = Convert.ToChar(Console.ReadLine());

        Console.Write("Input letter: ");
        letter2 = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);
    }
}
