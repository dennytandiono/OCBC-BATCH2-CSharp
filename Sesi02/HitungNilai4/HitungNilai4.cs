using System;

class HitungNilai4
{
    public static void Main(string[] args)
    {
        int umur;
        string pass;

        Console.Write("Enter Your Age : ");
        umur = int.Parse(Console.ReadLine());
        Console.Write("Password : ");
        pass = Console.ReadLine();

        bool isAdult = umur > 18;
        bool isPassword = pass == "OCBC";

        if(isAdult && isPassword)
        {
            Console.WriteLine("WELCOME TO THE CLUB");
        }
        else
        {
            Console.WriteLine("Sorry, Try Again");
        }
    }
}