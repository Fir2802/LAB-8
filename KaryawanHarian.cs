using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaji_KaryawanLab8
{
    class KaryawanHarian : Karyawan
    {
        public double upah_perjam { get; set; }
        public double jmlh_jamkerja { get; set; }
        public override double Gaji { get { return upah_perjam*jmlh_jamkerja; } }
    }
}