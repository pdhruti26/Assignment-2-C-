﻿//43. Write a program in C# Sharp to sort elements of the array in descending order.
using System;  
public class pro43
{  
    public static void Main() 
{
	int[] arr1 = new int[10];

    int n, i, j, tmp;
	
	
       Console.Write("\n\nsort elements of array in descending order :\n");
       Console.Write("----------------------------------------------\n");	

    Console.Write("Input the size of array : ");
		 n = Convert.ToInt32(Console.ReadLine());  

       Console.Write("Input {0} elements in the array :\n",n);
       for(i=0;i<n;i++)
            {
	      Console.Write("element - {0} : ",i);
		 arr1[i] = Convert.ToInt32(Console.ReadLine());  
	    }
    for(i=0; i<n; i++)
    {
        for(j=i+1; j<n; j++)
        {
            if(arr1[i] < arr1[j])
            {
                tmp = arr1[i];
                arr1[i] = arr1[j];
                arr1[j] = tmp;
            }
        }
    }

     Console.Write("\nElements of the array in sorted descending order:\n");
    for(i=0; i<n; i++)
    {
        Console.Write("{0}  ", arr1[i]);
    }
	        Console.Write("\n\n");
	}		
}
