using System;

class Soal4
{
    public static void Main()
    {
        int  n, reverse=0, remainder;

        Console.Write("Enter a number: ");      
        n= int.Parse(Console.ReadLine());

        while(n>0)      
        {      
            remainder = n%10;        
            reverse = reverse*10+remainder;      
            n/=10;      
        }      
       Console.Write("Reversed Number: "+reverse);       
    }
}