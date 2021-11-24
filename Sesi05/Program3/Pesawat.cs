using System;

public class Pesawat
{
        public string nama;
        public string ketinggian;
        public string jumlahPenumpang;
        public int jumlahRoda;

        public void terbang()
        {
            Console
                .WriteLine("Pesawat dengan nama {0} \n" +
                            "yang mempunyai jumlah roda {1} \n"+
                            "sedang berada pada ketinggian {2} \n"+
                            "dengan membawa jumlah penumpang sebanyak {3} \n" +
                            "sedang terbang",this.nama, this.jumlahRoda, this.ketinggian, this.jumlahPenumpang);
                Console.WriteLine("");
        }
}

public class pesawatTempur : Pesawat
{
    public void terbangTinggi()
    {
        Console
            .WriteLine("Pesawat Tempur dengan nama {0} \n" +
                        "yang mempunyai jumlah roda {1} \n"+
                        "sedang berada pada ketinggian {2} \n"+
                        "dengan membawa jumlah penumpang sebanyak {3} \n" +
                        "Akan meledakan senjata", this.nama, this.jumlahRoda, this.ketinggian, this.jumlahPenumpang);
                         Console.WriteLine("");
    }

}