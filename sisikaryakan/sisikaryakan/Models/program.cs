using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Manager tegar = new Manager("Manager Drilling");
            Manager haidar = new Manager("Manager Drilling");
            Manager sani = new Manager("Manager Refinery");
            Manager adi = new Manager("Manager General Affairs");

            Supervisor iqbal = new Supervisor("Supervisor Drilling Riau");
            Supervisor ucu = new Supervisor("Supervisor Drilling Luwuk");
            Supervisor dani = new Supervisor("Supervisor Refinery Balikpapan");

            Staff dwi = new Staff ("Staff Drilling Riau 1");
            Staff trio = new Staff("Straff Drilling Riau 2");
            Staff nuragus = new Staff("Staff Drilling Luwuk");
            Staff sofi = new Staff("Staff Refinery Balikpapan");
            Staff seta = new Staff("Staff General Affairs");

            tegar.name = "Tegar";
            tegar.entryDate = new DateTime(2015, 03, 27);
            tegar.basicSalary = 4500000;
            tegar.tunjanganHariRaya = 700000;
            tegar.tunjanganInternet = 560000;
            tegar.tunjanganKesehatan = 300000;
            tegar.tunjanganPenginapan = 700000;
            tegar.tunjanganTransportasi = 650000;
            tegar.studiBanding = 100000;


            haidar.name = "Haidar";
            haidar.entryDate = new DateTime(2015, 04, 15); ;
            haidar.basicSalary = 4500000;
            haidar.tunjanganHariRaya = 700000;
            haidar.tunjanganInternet = 560000;
            haidar.tunjanganKesehatan = 300000;
            haidar.tunjanganPenginapan = 700000;
            haidar.tunjanganTransportasi = 650000;
            haidar.studiBanding = 100000;

            sani.name = "Sani";
            sani.entryDate = new DateTime(2015, 04, 15); ;
            sani.basicSalary = 4500000;
            sani.tunjanganHariRaya = 700000;
            sani.tunjanganInternet = 560000;
            sani.tunjanganKesehatan = 300000;
            sani.tunjanganPenginapan = 700000;
            sani.tunjanganTransportasi = 650000;
            sani.studiBanding = 100000;

            adi.name = "Adi";
            adi.entryDate = new DateTime(2015, 04, 15); ;
            adi.basicSalary = 4500000;
            adi.tunjanganHariRaya = 700000;
            adi.tunjanganInternet = 560000;
            adi.tunjanganKesehatan = 300000;
            adi.tunjanganPenginapan = 700000;
            adi.tunjanganTransportasi = 650000;
            adi.studiBanding = 100000;

            iqbal.name = "Iqbal";
            iqbal.entryDate = new DateTime(2015, 05, 12);
            iqbal.basicSalary = 3500000;
            iqbal.tunjanganTransportasi = 500000;
            iqbal.tunjanganPenginapan = 700000;
            iqbal.tunjanganInternet = 400000;

            ucu.name = "Ucu";
            ucu.entryDate = new DateTime(2015, 05, 12);
            ucu.basicSalary = 3500000;
            ucu.tunjanganTransportasi = 500000;
            ucu.tunjanganPenginapan = 700000;
            ucu.tunjanganInternet = 400000;



            dani.name = "Dhani";
            dani.entryDate = new DateTime(2015, 09, 10);
            dani.basicSalary = 3500000;
            dani.tunjanganTransportasi = 500000;
            dani.tunjanganPenginapan = 700000;
            dani.tunjanganInternet = 400000;
            


            dwi.name = "Dwi";
            dwi.entryDate = new DateTime(2015, 07, 21);
            dwi.tunjanganTransportasi = 3000000;
            dwi.basicSalary = 40000;


            trio.name = "Trio";
            trio.entryDate = new DateTime(2015, 04, 20);
            trio.basicSalary = 3000000;
            trio.tunjanganTransportasi = 400000;

            nuragus.name = "Nuragus";
            nuragus.entryDate = new DateTime(2015, 04, 20);
            nuragus.basicSalary = 3000000;
            nuragus.tunjanganTransportasi = 400000;

            sofi.name = "Sofi";
            sofi.entryDate = new DateTime(2015, 04, 20);
            sofi.basicSalary = 3000000;
            sofi.tunjanganTransportasi = 400000;

            seta.name = "Seta";
            seta.entryDate = new DateTime(2015, 04, 20);
            seta.basicSalary = 3000000;
            seta.tunjanganTransportasi = 400000;

            Console.WriteLine("Sistem HR Sisikaryakan");
            Console.WriteLine("Pilih Data Karyawan yang ingin dicetak  (Masukan Angka): ");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Supervisor");
            Console.WriteLine("3. Staff");
            string Pilih = Console.ReadLine();


            if (Pilih == "1")
            {
                Console.WriteLine("Nama : " + haidar.name);
                Console.WriteLine("Jabatan : " + haidar.position);
                Console.WriteLine("Tanggal Masuk Kerja : " + haidar.entryDate);
                Console.WriteLine("Gaji Pokok : " + haidar.basicSalary);
                Console.WriteLine("Tunjangan Karyawan : " + haidar.tunjanganTransportasi);
                Console.WriteLine("Tunjangan Penginapan : " + haidar.tunjanganPenginapan);
                Console.WriteLine("Tunjangan Internet: " + haidar.tunjanganInternet);
                Console.WriteLine("Tunjangan Hari Raya: " + haidar.tunjanganHariRaya);
                Console.WriteLine("Tunjangan Kesehatan : " + haidar.tunjanganKesehatan + Environment.NewLine);

                Console.WriteLine("Nama : " + tegar.name);
                Console.WriteLine("Jabatan : " + tegar.position);
                Console.WriteLine("Tanggal Masuk Kerja : " + tegar.entryDate);
                Console.WriteLine("Gaji Pokok : " + tegar.basicSalary);
                Console.WriteLine("Tunjangan Karyawan : " + tegar.tunjanganPenginapan);
                Console.WriteLine("Tunjangan Penginapan : " + tegar.tunjanganTransportasi);
                Console.WriteLine("Tunjangan Internet: " + tegar.tunjanganInternet);
                Console.WriteLine("Tunjangan Hari Raya: " + tegar.tunjanganHariRaya);
                Console.WriteLine("Tunjangan Kesehatan : " + tegar.tunjanganKesehatan + Environment.NewLine);

                Console.WriteLine("Nama : " + sani.name);
                Console.WriteLine("Jabatan : " + sani.position);
                Console.WriteLine("Tanggal Masuk Kerja : " + sani.entryDate);
                Console.WriteLine("Gaji Pokok : " + sani.basicSalary);
                Console.WriteLine("Tunjangan Karyawan : " + sani.tunjanganPenginapan);
                Console.WriteLine("Tunjangan Penginapan : " + sani.tunjanganTransportasi);
                Console.WriteLine("Tunjangan Internet: " + sani.tunjanganInternet);
                Console.WriteLine("Tunjangan Hari Raya: " + sani.tunjanganHariRaya);
                Console.WriteLine("Tunjangan Kesehatan : " + sani.tunjanganKesehatan + Environment.NewLine);

                Console.WriteLine("Nama : " + adi.name);
                Console.WriteLine("Jabatan : " + adi.position);
                Console.WriteLine("Tanggal Masuk Kerja : " + adi.entryDate);
                Console.WriteLine("Gaji Pokok : " + adi.basicSalary);
                Console.WriteLine("Tunjangan Karyawan : " + adi.tunjanganPenginapan);
                Console.WriteLine("Tunjangan Penginapan : " + adi.tunjanganTransportasi);
                Console.WriteLine("Tunjangan Internet: " + adi.tunjanganInternet);
                Console.WriteLine("Tunjangan Hari Raya: " + adi.tunjanganHariRaya);
                Console.WriteLine("Tunjangan Kesehatan : " + adi.tunjanganKesehatan + Environment.NewLine);
                Console.ReadLine();
            }
            if (Pilih == "2")
            {

                Console.WriteLine("Nama : " + iqbal.name);
                Console.WriteLine("Jabatan : " + iqbal.position);
                Console.WriteLine("Tanggal Masuk Kerja : " + iqbal.entryDate);
                Console.WriteLine("Gaji Pokok : " + iqbal.basicSalary);
                Console.WriteLine("Tunjangan Karyawan : " + iqbal.tunjanganTransportasi);
                Console.WriteLine("Tunjangan Penginapan : " + iqbal.tunjanganPenginapan);
                Console.WriteLine("Tunjangan Internet: " + iqbal.tunjanganInternet + Environment.NewLine);

                Console.WriteLine("Nama : " + dani.name);
                Console.WriteLine("Jabatan : " + dani.position);
                Console.WriteLine("Tanggal Masuk Kerja : " + dani.entryDate);
                Console.WriteLine("Gaji Pokok : " + dani.basicSalary);
                Console.WriteLine("Tunjangan Karyawan : " + dani.tunjanganTransportasi);
                Console.WriteLine("Tunjangan Penginapan : " + dani.tunjanganPenginapan);
                Console.WriteLine("Tunjangan Internet: " + dani.tunjanganInternet + Environment.NewLine);

                Console.WriteLine("Nama : " + ucu.name);
                Console.WriteLine("Jabatan : " + ucu.position);
                Console.WriteLine("Tanggal Masuk Kerja : " + ucu.entryDate);
                Console.WriteLine("Gaji Pokok : " + ucu.basicSalary);
                Console.WriteLine("Tunjangan Karyawan : " + ucu.tunjanganTransportasi);
                Console.WriteLine("Tunjangan Penginapan : " + ucu.tunjanganPenginapan);
                Console.WriteLine("Tunjangan Internet: " + ucu.tunjanganInternet + Environment.NewLine);
                Console.ReadLine();
            }
            if (Pilih == "3")
            {
                Console.WriteLine("Nama : " + dwi.name);
                Console.WriteLine("Jabatan : " + dwi.position);
                Console.WriteLine("Tanggal Masuk Kerja : " + dwi.entryDate);
                Console.WriteLine("Gaji Pokok : " + dwi.basicSalary);
                Console.WriteLine("Tunjangan Karyawan : " + dwi.tunjanganTransportasi + Environment.NewLine);

                Console.WriteLine("Nama : " + trio.name);
                Console.WriteLine("Jabatan : " + trio.basicSalary);
                Console.WriteLine("Tanggal Masuk Kerja : " + trio.entryDate);
                Console.WriteLine("Gaji Pokok : " + trio.tunjanganTransportasi);
                Console.WriteLine("Tunjangan Karyawan : " + trio.position + Environment.NewLine);

                Console.WriteLine("Nama : " + nuragus.name);
                Console.WriteLine("Jabatan : " + nuragus.basicSalary);
                Console.WriteLine("Tanggal Masuk Kerja : " + nuragus.entryDate);
                Console.WriteLine("Gaji Pokok : " + nuragus.tunjanganTransportasi);
                Console.WriteLine("Tunjangan Karyawan : " + nuragus.position + Environment.NewLine);

                Console.WriteLine("Nama : " + sofi.name);
                Console.WriteLine("Jabatan : " + sofi.basicSalary);
                Console.WriteLine("Tanggal Masuk Kerja : " + sofi.entryDate);
                Console.WriteLine("Gaji Pokok : " + sofi.tunjanganTransportasi);
                Console.WriteLine("Tunjangan Karyawan : " + sofi.position + Environment.NewLine);

                Console.WriteLine("Nama : " + seta.name);
                Console.WriteLine("Jabatan : " + seta.basicSalary);
                Console.WriteLine("Tanggal Masuk Kerja : " + seta.entryDate);
                Console.WriteLine("Gaji Pokok : " + seta.tunjanganTransportasi);
                Console.WriteLine("Tunjangan Karyawan : " + seta.position + Environment.NewLine);
                Console.ReadLine();
            }
            else {
                Console.WriteLine("Input yang anda masukan salah");
                Console.ReadLine();
            }





        }
    }
}