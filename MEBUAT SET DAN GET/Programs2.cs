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



        //public void setData(string namaBaru, string statusSehat, string senjataBaru, int totalSenjata, int totalPower)
        //{
        //    this.nama = namaBaru;
        //    this.kesehatan = statusSehat;
        //    this.senjata = senjataBaru;
        //    this.jumlahSenjata = totalSenjata;
        //    this.jumlahPower = totalPower;
        //}

        //public void getData()
        //{
        //    Console.Write(nama);
        //    Console.Write(" / ");
        //    Console.Write(kesehatan);
        //    Console.Write(" / ");
        //    Console.Write(senjata);
        //    Console.Write(" / ");
        //    Console.Write(jumlahSenjata);
        //    Console.Write(" / ");
        //    Console.WriteLine(jumlahPower);
        //}

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

            Karakter player1 = new Karakter("Febrian", "Sehat", "Pedang"); //membuat object
            player1.getData(); //memanggil method getData


            //// kode pertemuan sebelumnya
            //List<Karakter> daftarHero = new List<Karakter>();

            //Karakter player1 = new Karakter();
            //player1.setData("Archer", "Sehat", "Pedang", 2, 50);

            //Karakter player2 = new Karakter();
            //player2.setData("Goblin", "Kritis", "Pisau", 1, 75);

            //Karakter enemy = new Karakter();
            //enemy.setData("Zombie", "Sehat", "Pukulan Tangan", 1, 5);

            //daftarHero.Add(player1);
            //daftarHero.Add(player2);
            //daftarHero.Add(enemy);

            //foreach (Karakter player in daftarHero)
            //{
            //    player.getData();
            //}

        }
    }
}