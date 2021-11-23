using System;

class AksesArray
{
    public static void Main()
    {
        string[] contoh = new string[4]
        {
            "Mobo", "Processor", "Power Supply", "Video Card"
        };

        Console.WriteLine("Menampilkan semua data dalam array");
        Console.WriteLine("");


        foreach(string contoh1 in contoh)
        {
            Console.WriteLine(contoh1);
        }

        Console.WriteLine("Press any key to continue . . .");
    }
}