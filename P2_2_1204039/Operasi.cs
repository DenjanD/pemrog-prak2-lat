using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204039
{
    public class Operasi : Pemeriksaan
    {
        protected int biaya;

        public Operasi(string jenis, string nama, int umur) : base(jenis, nama, umur)
        {
            this.biaya = 50000;
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
