using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            pesawatTempur pswtempur = new pesawatTempur();

            pesawat.nama = "Helly";
            pesawat.jumlahRoda = 3;
            pesawat.ketinggian = "1000 kaki";
            pesawat.jumlahPenumpang = "3 Penumpang";

            pswtempur.nama = "AZ500TPU";
            pswtempur.jumlahRoda = 5;
            pswtempur.ketinggian = "200 kaki";
            pswtempur.jumlahPenumpang = "2 Penumpang plus kopoloy dan assitance";

            pesawat.terbang();
            pswtempur.terbangTinggi();
            Console.Read();
        }
    }
}
