using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace KerangkaGame
{
    class Karakter
    {
        public int jumlahSenjata, jumlahPower;

        //enskapsulasi data
        public string nama { get; private set; }
        public int kesehatan { get; private set; }
        public string senjata { get; private set; }

        public Karakter(string nama, int kesehatan, string senjata)
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;
        }

        public void serang(Karakter target)
        {
           Console.WriteLine("mulai menyerang " + target.nama);
            target.TerimaSerangan(50); // Contoh damage
        }

        public void TerimaSerangan(int jumalahSerangan)
        {
            kesehatan -= jumalahSerangan;
            Console.WriteLine($"{nama} diserang dengan {jumalahSerangan}, kesehatan sekarang: {kesehatan}");
            if (kesehatan <= 0)
            {
                Console.WriteLine($"{nama} telah kalah!");
            }
        }

       

        public void getData()
        {
            Console.Write($"Karakter: {nama}");
            Console.Write(" / ");
            Console.Write(kesehatan);
            Console.Write(" / ");
            Console.WriteLine(senjata);
        }
    }

    class MainProgram
    {
        static void Main(string[] args)
        {

            Karakter player1 = new Karakter("Febrian", 100, "Pedang"); //membuat object
            Karakter musuh = new Karakter("Goblin", 100, "Pisau"); //membuat object
            player1.serang(musuh);
            player1.getData();
            musuh.getData();


            

        }
    }
}
