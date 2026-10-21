//using System;

//namespace KerangkaGame
//{
//    class Karakter
//    {
//        public string namaKarakter, namaSenjata;
//        public int kekuatanKarakter;
//        int kesehatanKarakter;

//        public Karakter(string nama, string senjata, int kekuatan, int kesehatan)
//        {
//            namaKarakter = nama;
//            namaSenjata = senjata;
//            kekuatanKarakter = kekuatan;
//            kesehatanKarakter = kesehatan;
//        }

//        public void setSenjata(string Namasenjata)
//        {
//            namaSenjata = Namasenjata;
//        }

//        public void tampilKarakter()
//        {
//            Console.WriteLine("karaktermu : " + namaKarakter + " / kekuatan: " + kekuatanKarakter + " / kesehatan : " + kesehatanKarakter);
//        }

//        public int posisiAwal { get; private set; }
//        public int posisiSaatIni { get; private set; }


//        //menambahkan method baru untuk menampilkan posisi awal dan posisi saat ini
//        public void PindahPosisi(int posisiAwal, int posisiSaatIni)
//        {
//            this.posisiAwal = posisiAwal;
//            this.posisiSaatIni = posisiSaatIni;
//            Console.WriteLine($"{namaKarakter} berpindah dari posisi {posisiAwal} ke posisi {posisiSaatIni}");
//        }

//        public void tampilKesehatan()
//        {
//            Console.WriteLine("kesehatan Karakter : " + kesehatanKarakter);
//        }
//    }

//    class KarakterDua
//    {
//        public string nama;

//        public void setNama(string namaKarakter)
//        {
//            nama = namaKarakter;
//        }


//        public void tampilNama()
//        {
//            Console.WriteLine("nama Karakter : " + nama);
//        }
//    }

//    class MyGame
//    {
//        static void Main(string[] args)
//        {
//            Karakter karakter = new Karakter("Febri", "AK-47s", 100, 200);
//            karakter.tampilKarakter();

//            Console.Write("Masukkan posisi awal: ");
//            int posAwal = int.Parse(Console.ReadLine());
//            Console.Write("Masukkan posisi saat ini: ");
//            int posSekarang = int.Parse(Console.ReadLine());
//            karakter.PindahPosisi(posAwal, posSekarang);



//            // KarakterDua karakterDua = new KarakterDua();
//            // karakterDua.setNama("Minion");
//            // karakterDua.tampilNama();

//        }
//    }
//}


