using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204039
{
    class Sterilisasi : Pemeriksaan
    {
        protected int biaya;

        public Sterilisasi(string jenis, string nama, int umur) : base(jenis, nama, umur)
        {
            this.biaya = 45000;
        }

        public int biayaTagihan
        {
            get
            {
                return biaya;
            }

            set
            {
                biaya = value;
            }
        }
    }
}
