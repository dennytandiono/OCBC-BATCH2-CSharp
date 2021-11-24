using System;

class Program1
{
    public static void Main(string[] args)
    {
        string merkLaptop;
        int ramLaptop;
        int memoryLaptop;

        Laptop laptop1 = new Laptop();


        Console.Write("Input merk laptop : ");
        merkLaptop = Console.ReadLine();
        Console.Write("Input ram laptop : ");
        ramLaptop = int.Parse(Console.ReadLine());
        Console.Write("Input memory laptop : ");
        memoryLaptop = int.Parse(Console.ReadLine());

        laptop1.merk = merkLaptop;
        laptop1.ram = ramLaptop;
        laptop1.memory = memoryLaptop;


        Console.WriteLine("\n merk laptop adalah {0}", laptop1.merk);
        Console.WriteLine("\n ram laptop adalah {0}", laptop1.ram);
        Console.WriteLine("\n memory laptop adalah {0}", laptop1.memory);

        laptop1.Chatting();
        laptop1.Sosmed();
        laptop1.Onlineshop();

        Console.Read();
    }
}