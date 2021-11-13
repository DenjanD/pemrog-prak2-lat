using System;

namespace P2_2_1204039
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- KALKULATOR BIAYA PEMERIKSAAN HEWAN PUSKESWAN ALFIEN ---");

            Console.Write("Masukkan Jenis Hewan Anda: ");
            string jenisHewan = Console.ReadLine();

            Console.Write("Masukkan Nama Hewan Anda: ");
            string namaHewan = Console.ReadLine();

            Console.Write("Masukkan Umur Hewan Anda (Satuan Bulan): ");
            string cekUmurHewan = Console.ReadLine();
            int umurHewan = cekUmur(cekUmurHewan);

            Console.WriteLine("\n===================================");
            Console.WriteLine("Data Hewan Anda: " +
                "\n 1. Jenis Hewan: "+jenisHewan+
                "\n 2. Nama Hewan: "+namaHewan+
                "\n 3. Umur Hewan: "+umurHewan+" Bulan");
            Console.WriteLine("===================================");

            Console.WriteLine("\nJenis Pemeriksaan Tersedia: " +
                "\n A. Pemeriksaan Kesehatan"+
                "\n B. Operasi Hewan"+ 
                "\n C. Sterilisasi Hewan");

            Console.Write("Masukkan Pilihan Pemeriksaan Anda: ");
            string cekPilihanPemeriksaan = Console.ReadLine();
            char pilihanPemeriksaan = cekPilihan(cekPilihanPemeriksaan);
            int biayaPemeriksaan = 0;

            if (pilihanPemeriksaan == 'A')
            {
                Kesehatan periksaKesehatan = new Kesehatan(jenisHewan, namaHewan, umurHewan);
                biayaPemeriksaan = periksaKesehatan.biayaTagihan;
            } else if (pilihanPemeriksaan == 'B')
            {
                Operasi periksaOperasi = new Operasi(jenisHewan, namaHewan, umurHewan);
                biayaPemeriksaan = periksaOperasi.biayaTagihan;
            } else if (pilihanPemeriksaan == 'C')
            {
                Sterilisasi periksaSterilisasi = new Sterilisasi(jenisHewan, namaHewan, umurHewan);
                biayaPemeriksaan = periksaSterilisasi.biayaTagihan;
            }

            Console.WriteLine("Untuk biaya pemeriksaan hewan Anda sejumlah: Rp "+Convert.ToString(biayaPemeriksaan));

            //methodssssss
            static int cekUmur(string umurHewan)
            {
                int umur;

                while (!int.TryParse(umurHewan, out umur)) {
                    Console.Write("Masukkan Umur Hewan Anda Dalam Angka (Satuan Bulan): ");
                    umurHewan = Console.ReadLine();
                }     

                umur = Convert.ToInt32(umurHewan);
                return umur;
            }

            static char cekPilihan(string pilihanPemeriksaan)
            {
                char pilihan;

                while (!char.TryParse(pilihanPemeriksaan, out pilihan))
                {
                    if (pilihanPemeriksaan == "A" || pilihanPemeriksaan == "B" || pilihanPemeriksaan == "C")
                    {
                        break;
                    }
                    Console.Write("Masukkan Pilihan Yang Tersedia: ");
                    pilihanPemeriksaan = Console.ReadLine();
                }

                pilihan = Convert.ToChar(pilihanPemeriksaan);
                return pilihan;
            }
        }
    }
}
