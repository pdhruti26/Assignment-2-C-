﻿//17. Write a C# Sharp program to find the largest of three numbers

using System;
class pro17
{
    static void Main(string[] args)
{
 
int number1, number2, number3;
string result;
 
Console.Write("Input the first number :");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number :");
number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number :");
number3 = Convert.ToInt32(Console.ReadLine());
 
if (number1 > number2 && number1 > number3)
{ 
result= "The 1st Number is the greatest among three. \n";
}
else if (number2 > number1 && number2 > number3)
{
result = "The 2nd Number is the greatest among three \n";
}
else
{
result= "The 3rd Number is the greatest among three \n";
}
 
Console.WriteLine(result);
 
Console.ReadLine();
 
}
}