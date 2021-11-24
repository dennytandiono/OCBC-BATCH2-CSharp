using System;

namespace Program2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            pesawat.nama = "GARUDA";
            pesawat.ketinggianSetterGetter = "2500 kaki";

            pesawat.terbang();
            pesawat.sudahTerbang();
            Console.Read();
        
        }
    }
}
