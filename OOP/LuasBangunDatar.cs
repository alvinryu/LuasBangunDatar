using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Luas
    {
        protected string name;

        public virtual void cetakNama()
        {
            Console.WriteLine("Menghitung program luas bangun datar");
        }
    }

    class Persegi : Luas
    {
        private double sisi;

        public Persegi(string name)
        {
            this.name = name;
        }

        public override void cetakNama()
        {
            Console.WriteLine("Menghitung luas " + name);
        }

        public double hitungLuas
        {
            get { return sisi * sisi; }
            set { sisi = value; }
        }
    }

    class PersegiPanjang : Luas
    {
        private double panjang;
        private double lebar;

        public PersegiPanjang(string name)
        {
            this.name = name;
        }

        public override void cetakNama()
        {
            Console.WriteLine("Menghitung luas " + name);
        }

        public double Panjang
        {
            set { panjang = value; }
        }

        public double Lebar
        {
            set { lebar = value;  }
        }

        public double hitungLuas
        {
            get { return panjang * lebar; }
        }
    }

    class Segitiga : Luas
    {
        private double alas;
        private double tinggi;

        public Segitiga(string name)
        {
            this.name = name;
        }

        public override void cetakNama()
        {
            Console.WriteLine("Menghitung luas " + name);
        }

        public double Alas
        {
            set { alas = value; }
        }

        public double Tinggi
        {
            set { tinggi = value; }
        }

        public double hitungLuas
        {
            get { return (0.5 * alas * tinggi); }
        }
    }

    class LuasBangunDatar
    {
        static void Main(String[] args)
        {
            int repeat = 1;

            while(repeat != 0)
            {
                Console.WriteLine("1.Hitung Luas Persegi");
                Console.WriteLine("2.Hitung Luas Persegi Panjang");
                Console.WriteLine("3.Hitung Luas Segitiga");
                Console.WriteLine("0.Keluar dari program");
                Console.WriteLine("===================================");

                try
                {
                    Console.Write("Pilih menu: ");
                    repeat = Convert.ToInt32(Console.ReadLine());

                    if (repeat == 0)
                    {
                        break;
                    }
                    else if (repeat == 1)
                    {
                        Persegi persegi = new Persegi("Persegi");
                        Console.Write("Masukkan Nilai sisi: ");
                        persegi.hitungLuas = Convert.ToInt32(Console.ReadLine());

                        persegi.cetakNama();
                        Console.WriteLine("Luas persegi tersebut adalah " + persegi.hitungLuas + "\n\n");
                    }
                    else if (repeat == 2)
                    {
                        PersegiPanjang persegiPanjang = new PersegiPanjang("Persegi Panjang");
                        Console.Write("Masukkan Nilai panjang: ");
                        persegiPanjang.Panjang = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Masukkan Nilai lebar: ");
                        persegiPanjang.Lebar = Convert.ToInt32(Console.ReadLine());

                        persegiPanjang.cetakNama();
                        Console.WriteLine("Luas persegi panjang tersebut adalah " + persegiPanjang.hitungLuas + "\n\n");
                    }
                    else if (repeat == 3)
                    {
                        Segitiga segitiga = new Segitiga("Segitiga");
                        Console.Write("Masukkan Nilai alas: ");
                        segitiga.Alas = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Masukkan Nilai tinggi: ");
                        segitiga.Tinggi = Convert.ToInt32(Console.ReadLine());

                        segitiga.cetakNama();
                        Console.WriteLine("Luas persegi panjang tersebut adalah " + segitiga.hitungLuas + "\n\n");
                    }
                    else
                    {
                        Console.WriteLine("Menu yang Anda masukkan tidak ada. Silahkan pilih lagi");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }

            }

            Console.WriteLine("\nAnda telah keluar dari program");
            Console.ReadLine();
        } 
    }
}
