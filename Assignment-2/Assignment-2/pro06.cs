//6.	Write a C# Sharp program that takes the radius of a sphere as input and calculate and display the surface and volume of the sphere.
using System;
public class pro6
{
    public static void Main()
    {   
        float r;
        float pi = 3.1415926535f;
         
        Console.Write("Radius: ");
        r = Convert.ToSingle(Console.ReadLine());
         
        Console.WriteLine( 4 * pi * (r * r) );
         
        Console.WriteLine( 4f/3f * pi * (r * r * r));
    }
}
