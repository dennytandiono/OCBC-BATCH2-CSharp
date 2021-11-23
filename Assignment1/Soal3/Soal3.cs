using System;

class Soal3
{
    public static void Main()
    {
        int i,fact=1,number;      
        Console.Write("Enter any Number: ");      
        number= int.Parse(Console.ReadLine());     
        for(i=1;i<=number;i++)
        {      
            fact *= i;     
        }      
       Console.Write("Factorial of " +number+" is: "+fact); 
    }
}