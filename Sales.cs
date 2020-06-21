using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaji_karyawanLab8
{
    class Sales : Karyawan
    {
        public double jmlh_penjualan { get; set; }
        public double komisi { get; set; }

        public override double Gaji { get { return jmlh_penjualan*komisi; } }
    }
}