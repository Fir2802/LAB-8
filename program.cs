using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaji_KaryawanLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            KaryawanTetap karyawantetap = new KaryawanTetap();

            karyawantetap.nik = "19.11.2675";
            karyawantetap.nama = "Lakey firmansyah";
            karyawantetap.gaji_bulanan = 1000000;

            KaryawanHarian karyawanharian = new KaryawanHarian();

            karyawanharian.nik = "19.11.2676";
            karyawanharian.nama = "Annisa";
            karyawanharian.jmlh_jamkerja = 35;
            karyawanharian.upah_perjam = 35000;

            Sales sales = new Sales();
            
            sales.nik = "19.11.2677";
            sales.nama = "Mulyanto";
            sales.jmlh_penjualan = 23;
            sales.komisi = 40000;


            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);

            int nomor = 1;
            
            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine();
                Console.WriteLine("{0}.Nama\t: {1}   ,NIK\t: {2}   ,Gaji\t: {3:N0}",nomor,karyawan.nama,karyawan.nik,karyawan.Gaji);
                nomor++;
            }

            Console.ReadKey();
        }
    }
}