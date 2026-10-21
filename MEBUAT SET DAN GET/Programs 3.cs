using System;

namespace KerangkaGame
{
    class Karakter
    {
        public string namaKarakter;
        public string namaSenjata;
        public int kekuatanKarakter;
        public int kesehatanKarakter;

        public Karakter(string nama, string senjata, int kekuatan, int kesehatan)
        {
            namaKarakter = nama;
            namaSenjata = senjata;
            kekuatanKarakter = kekuatan;
            kesehatanKarakter = kesehatan;
        }

        public void tampilKarakter()
        {
            Console.WriteLine("karaktermu : " + namaKarakter + " / kekuatan: " + kekuatanKarakter + " / kesehatan : " + kesehatanKarakter);
        }
    }

    class MyGame
    {
        static void Main()
        {
            Karakter karakter = new Karakter("ACIL", "AK-47s", 100, 200);
            karakter.tampilKarakter();
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Mana yang kamu pilih ?");
                Console.WriteLine("1. perpindahan angka");
                Console.WriteLine("2. tombol keyboard");
                Console.WriteLine("3. exit");
                Console.Write("Pilihan: ");
                int pilihan = int.Parse(Console.ReadLine());
                Console.WriteLine();

            int posisi = 0;

            if (pilihan == 1)
            {
                // Mode perpindahan angka (input angka langsung)
                Console.WriteLine("=== PERPINDAHAN ANGKA ===");
                int posAwal = 0;
                posisi = 0;
                Console.WriteLine($"Posisi awal: {posAwal}");
                Console.WriteLine($"POSISI SAAT INI : {posisi}");
                while (true)
                {
                    Console.Write("Masukkan jumlah pindah (ketik exit untuk keluar): ");
                    string input = Console.ReadLine();
                    if (input.ToLower() == "exit")
                    {
                        Console.WriteLine("\nProgram selesai. Tekan tombol apa saja untuk menutup.");
                        Console.ReadKey();
                        return;
                    }
                    int jumlah = int.Parse(input);
                    posAwal = posisi;
                    posisi += jumlah;
                    Console.WriteLine($"Berpindah dari posisi {posAwal} ke posisi {posisi}");
                    Console.WriteLine($"POSISI SAAT INI : {posisi}");
                }
            }
            else if (pilihan == 2)
            {
                // Mode tombol keyboard
                Console.WriteLine("=== GAME POSISI CMD ===");
                Console.WriteLine("Tekan panah KANAN untuk menambah (+2)");
                Console.WriteLine("Tekan panah KIRI untuk mengurangi (-1)");
                Console.WriteLine("Tekan 'ESC' untuk keluar.\n");
                posisi = 0;
                Console.WriteLine($"POSISI SAAT INI : {posisi}");

                while (true)
                {
                    // Baca input keyboard tanpa perlu enter
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    // Keluar pakai ESC
                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("\nProgram selesai. Tekan tombol apa saja untuk menutup.");
                        Console.ReadKey();
                        return;
                    }

                    // Panah kanan 
                    if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        if (posisi < 99) 
                        {
                            posisi += 2;
                            Console.WriteLine($"POSISI SAAT INI : {posisi}");
                        }
                    }


                    // Panah kiri 
                    else if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        if (posisi > -99) 
                        {
                            posisi -= 1;
                            Console.WriteLine($"POSISI SAAT INI : {posisi}");
                        }
                    }
                }
            }
            else if (pilihan == 3)
            {
                Console.WriteLine("\nProgram selesai. Tekan tombol apa saja untuk menutup.");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid.");
            }
            }
        }
    }
}