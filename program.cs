using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Inheritance, Abstraction & Collection";

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "112-221-121";
            karyawanTetap.Nama = "Abbiyu Bima Aditya";
            karyawanTetap.GajiPerBulan = 3500000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "192-166-143";
            karyawanHarian.Nama = "I Merda Aing Pramesti";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.GajiPerJam = 14500;

            Sales sales = new Sales();
            sales.Nik = "323-180-100";
            sales.Nama = "Stefan William";
            sales.JumlahPenjualan = 21;
            sales.Komisi = 43000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}