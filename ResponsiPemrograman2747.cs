using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Nama : umi solihah");
            Console.WriteLine("NIM  : 19.11.2747");
            Console.WriteLine("");

            Karyawan karyawan1 = new Karyawan();
            Karyawan karyawan2 = new Karyawan();
            Karyawan karyawan3 = new Karyawan();

            karyawan1.No = 1;
            karyawan1.Nik = 19112747;
            karyawan1.Nama = "umi solihah";
            karyawan1.Gaji = 3500000;

            karyawan2.No = 2;
            karyawan2.Nik = 19112732;
            karyawan2.Nama = "yuniar andwi";
            karyawan2.Gaji = 2000000;

            karyawan3.No = 3;
            karyawan3.Nik = 19112766;
            karyawan3.Nama = "nurul hikma";
            karyawan3.Gaji = -50;

            Console.WriteLine("No /   NIK/Nama/Gaji     ");
            Console.WriteLine("----------------------------------------");
            karyawan1.InfoKaryawan();
            karyawan2.InfoKaryawan();
            karyawan3.InfoKaryawan();
            Console.WriteLine("");
            Console.WriteLine("Anda dapat kenaikan gaji 10%");
            Console.WriteLine("");
            Console.WriteLine("No /   NIK/Nama/Gaji     ");
            Console.WriteLine("----------------------------------------");
            karyawan1.BonusGaji();
            karyawan2.BonusGaji();
            karyawan3.BonusGaji();
	}
	public class Karyawan
    {
        public int No { get; set; }
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int Gaji { get; set; }

       

        public void InfoKaryawan()
        {
            if (Gaji < 0)
            {
                Gaji = 0;
            }

            Console.WriteLine("{0}  / {1}/{2}/{3}        ", No, Nik, Nama, Gaji);
            
        }

        public void BonusGaji()
        {
            if (Gaji < 0)
            {
                Gaji = 0;
            }

            Console.WriteLine("{0}  / {1}/{2}/{3}        ", No, Nik, Nama, Gaji*0.1+Gaji);

        }


    }
}