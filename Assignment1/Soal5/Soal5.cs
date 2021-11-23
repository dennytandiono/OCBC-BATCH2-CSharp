using System;

class Soal5
{
    public static void Main()
    {
       int n,temp = 0,rem ;     
       Console.Write("Enter the Number= ");    
       n= int.Parse(Console.ReadLine());     
       while(n>0)      
       {      
            rem=n%10;      
            temp=temp*10+rem;      
            n=n/10;      
       }      
       n = temp;      
       while(n>0)      
       {      
            rem=n%10;      
            switch(rem)      
        {      
            case 1:      
            Console.Write("one ");  
            break;      
            case 2:      
            Console.Write("two ");      
            break;      
            case 3:      
            Console.Write("three ");    
            break;      
            case 4:      
            Console.Write("four ");    
            break;      
            case 5:      
            Console.Write("five ");    
            break;      
            case 6:      
            Console.Write("six ");     
            break;      
            case 7:    
            Console.Write("seven ");    
            break;    
            case 8:      
            Console.Write("eight ");      
            break;      
            case 9:      
            Console.Write("nine ");    
            break;      
            case 0:      
            Console.Write("zero ");    
            break;      
            default:      
            Console.Write("=====");      
            break;      
        }     
        n=n/10;      
       }      
    }  
  }  