using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "zehra";
            string Soyadi = "X";
            int ID = 23254;
            string HesapTürü = "vadesiz";
            string ParaTipi = "TL";
            int AnlikToplamTutar = 15000;

            string[] musteriler = new string[] { "Zehra", "Emre", "Esra", "Emir" };

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Zehra";
            musteri1.Soyadi = "X";
            musteri1.ID = 23254;
            musteri1.HesapTürü = "vadesiz";
            musteri1.ParaTipi = "TL";
            musteri1.AnlikToplamTutar = 15000;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Emre";
            musteri2.Soyadi = "Y";
            musteri2.ID = 15632;
            musteri2.HesapTürü = "vadesiz";
            musteri2.ParaTipi = "TL";
            musteri2.AnlikToplamTutar = 88000;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Esra";
            musteri3.Soyadi = "Z";
            musteri3.ID = 45632;
            musteri3.HesapTürü = "vadesiz";
            musteri3.ParaTipi = "TL";
            musteri3.AnlikToplamTutar = 77000;

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Emir";
            musteri4.Soyadi = "T";
            musteri4.ID = 78512;
            musteri4.HesapTürü = "vadesiz";
            musteri4.ParaTipi = "TL";
            musteri4.AnlikToplamTutar = 36000;




            Musteri[] musteri = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            foreach (var Musteri in musteri)
            {
                Console.WriteLine(Musteri.Adi);
                Console.WriteLine(Musteri.Soyadi);
                Console.WriteLine(Musteri.ID);
                Console.WriteLine(Musteri.HesapTürü);
                Console.WriteLine(Musteri.ParaTipi);
                Console.WriteLine(Musteri.AnlikToplamTutar);

            }


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

            musteriManager.Ekle2("Zehra", "X", 23254, "vadesiz", "TL", 15000, true);
            musteriManager.Ekle2("Emre", "Y", 12354, "vadesiz", "TL", 35000, true);
            musteriManager.Ekle2("Esra", "Z", 78546, "vadesiz", "TL", 77000, false);
            musteriManager.Ekle2("Emir", "T", 45698, "vadesiz", "TL", 15000, true);

            Console.ReadLine();

        }
    }
}