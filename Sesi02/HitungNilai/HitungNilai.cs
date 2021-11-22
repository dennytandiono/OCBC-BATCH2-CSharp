using System;

class HitungNilai
{
    public static void Main(string[]  args)
    {
        int nilai1, nilai2, nilai3, total;
        double avg;

        Console.WriteLine("===Menghitung Nilai===");
        Console.Write("Masukan nilai PERTAMA : ");
        nilai1 = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai KEDUA : ");
        nilai2 = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai KETIGA : ");
        nilai3 = int.Parse(Console.ReadLine());
        
        total = nilai1+nilai2+nilai3;
        avg = total/3.0;

        Console.WriteLine("Total Nilai Adalah : " + total);
        Console.WriteLine("Rata Rata Nilai Adalah : " + avg);
        Console.Read();
    }

}