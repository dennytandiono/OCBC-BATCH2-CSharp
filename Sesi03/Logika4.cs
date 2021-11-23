using System;

class Logika4
{
    public static void Main(string[] args)
    {
        double nilai;
        Console.Write("Nilai : ");
        nilai = double.Parse(Console.ReadLine());

        if( nilai >= 85 )
        {
            Console.WriteLine("Kamu mendapat nilai A");
        }
        else if( nilai >= 65 )
        {
            Console.WriteLine("Kamu mendapat nilai B");
        }
        else if( nilai >= 45 )
        {
            Console.WriteLine("Kamu mendapat nilai C");
        }
        else if( nilai >= 25 )
        {
            Console.WriteLine("Kamu mendapat nilai D");
        }
        else if ( nilai < 25 )
        {
            Console.WriteLine("Kamu mendapat nilai E");
        }

    }
}