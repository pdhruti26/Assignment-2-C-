//7. Write a C# Sharp program that takes a character as input and check the input (lowercase) is a vowel, a digit, or any other symbol.

using System;
public class pro7
{
    public static void Main()
    {
        char symbol;

        Console.Write("Input a symbol: ");
        symbol = Convert.ToChar(Console.ReadLine());

        if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                (symbol == 'o') || (symbol == 'u'))
            Console.WriteLine("It's a lowercase vowel.");
        else if ((symbol >= '0') && (symbol <= '9'))
            Console.WriteLine("It's a digit.");
        else
            Console.Write("It's another symbol.");
    }
}
