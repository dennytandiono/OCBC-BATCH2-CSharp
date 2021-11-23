using System;

class Logika3
{
    public static void Main(string[] args)
    {
        string uname,pass;
        
        Console.Write("Username : ");
        uname = Console.ReadLine();
        Console.Write("Password : ");
        pass = Console.ReadLine();

        if(uname == "ocbc" && pass == "bootcamp")
        {
            Console.WriteLine("Anda berhasil login");
        }
        else
        {
            Console.WriteLine("Username atau Password salah");
        }
    }
}