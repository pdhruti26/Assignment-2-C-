//20. Write a C# Sharp program to read temperature in centigrade and display a suitable messageaccording to temperature state below :
//Temp < 0 then Freezing weather
//Temp 0-10 then Very Cold weather
//Temp 10-20 then Cold weather
//Temp 20-30 then Normal in Temp
//Temp 30-40 then Its Hot
//Temp >=40 then Its Very Hot 

using System;
public class pro20
{
    public static void Main()
    {
        int tmp;
        Console.Write("\n\n");
        Console.Write("Accept a temperature in centigrade and display a suitable message:\n");
        Console.Write("--------------------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input days temperature : ");
        tmp = Convert.ToInt32(Console.ReadLine());
        if (tmp < 0)
            Console.Write("Freezing weather.\n");
        else if (tmp < 10)
            Console.Write("Very cold weather.\n");
        else if (tmp < 20)
            Console.Write("Cold weather.\n");
        else if (tmp < 30)
            Console.Write("Normal in temp.\n");
        else if (tmp < 40)
            Console.Write("Its Hot.\n");
        else
            Console.Write("Its very hot.\n");

    }
}
