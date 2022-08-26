//4.	Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle.

using System;
 class PRO4
{
     static void Main()
    {

        double r, per_cir;
        double PI = 3.14;
        Console.WriteLine("Input the radius of the circle : ");
        r = Convert.ToDouble(Console.ReadLine());
        per_cir = 2 * PI * r;
        Console.WriteLine("Perimeter of Circle : {0}", per_cir);
        Console.Read();
    }
}
 
