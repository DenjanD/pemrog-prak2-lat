using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204039
{
    public class Kesehatan: Pemeriksaan
    {
        protected int biaya;

        public Kesehatan(string jenis, string nama, int umur) : base(jenis, nama, umur)
        {
            this.biaya = 30000;
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
