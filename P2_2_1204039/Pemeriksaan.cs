using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204039
{
    public class Pemeriksaan
    {
        public String jenisHewan;
        public String namaHewan;
        public int umurHewan;
        
        public Pemeriksaan()
        {

        }

        public Pemeriksaan(string jenis, string nama, int umur)
        {
            this.jenisHewan = jenis;
            this.namaHewan = nama;
            this.umurHewan = umur;
        }

        public string jenis
        {
            get
            {
                return jenisHewan;
            }

            set
            {
                jenisHewan = value;
            }
        }
        
        public string nama
        {
            get
            {
                return namaHewan;
            }

            set
            {
                namaHewan = value;
            }
        }

        public int umur
        {
            get
            {
                return umurHewan;
            }

            set
            {
                umurHewan = value;
            }
        }
    }
}
