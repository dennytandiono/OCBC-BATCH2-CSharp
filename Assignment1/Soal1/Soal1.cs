    using System;  
  public class Soal1  
   {  
     public static void Main()  
       {  
            int input = 0;

            Console.Write("Input Range : ");
            input = int.Parse(Console.ReadLine());

            char huruf='A';      
            int i, j, k, m;      
            for(i=1; i<=input; i++)      
            {      
                for(j=1; j <= input-i; j++)
                {      
                    Console.Write(" ");
                }
                for(k=1;k<=i;k++)
                {
                    Console.Write(huruf++);      
                }    
                huruf--;
                for(m=1;m<i;m++)
                {      
                    Console.Write(--huruf);   
                }   
            Console.Write("\n");
            huruf='A';      
            }      
        }  
  }