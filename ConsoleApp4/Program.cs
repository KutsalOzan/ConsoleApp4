using System;

namespace ConsoleApp4
{
    public abstract class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public DateTime DogumTarihi { get; set; }

        private float Boy;
        private float Kilo;

        public abstract int Yas(DateTime DogTar);

        public float VucutKitleEndeksi(float Boy, float Kilo)
            => Kilo / (Boy * Boy);

        public decimal VucutKitleEndeksi(decimal boy, decimal kilo)
            => kilo / (boy * boy);

        public double VucutKitleEndeksi(double boy, double kilo)
            => kilo / (boy * boy);

    }

    public class Personel : Kisi
    {
        public DateTime IseGirisTarihi { get; set; }
        public long SGK_No { get; set; }

        public override int Yas(DateTime DogTar)
            => DateTime.Today.Year - DogTar.Year;
        


    }
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel()
            {
                Ad = "Ozan",
                Soyad = "Aslan",
                DogumTarihi = new DateTime(2001, 08, 19),
                IseGirisTarihi = new DateTime(2015, 06, 21),
                SGK_No = 2321321321251,

            };
            Console.WriteLine($"Ad: {personel.Ad}");
            Console.WriteLine($"Soyad: {personel.Soyad}");
            Console.WriteLine($"Doğum Tarihi : ");
            Console.WriteLine(personel.DogumTarihi.ToShortDateString());
            Console.Write("İşe Giriş Tarihi : ");
            Console.WriteLine(personel.IseGirisTarihi.ToShortDateString());
            Console.WriteLine($"SGK No: {personel.SGK_No}");
            Console.WriteLine($"Yaşı : {personel.Yas(personel.DogumTarihi)}");

            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine(" ");

            Console.Write($"{nameof(personel.VucutKitleEndeksi)}");
            Console.Write($"{typeof(float)}:");

            Console.WriteLine($"{personel.VucutKitleEndeksi(1.80,74.4)}");
            Console.Write($"{nameof(personel.VucutKitleEndeksi)}");
            Console.Write($"{typeof(decimal)}");
            Console.WriteLine($"{personel.VucutKitleEndeksi(1.76,80.5)}");
            Console.Write($"{nameof(personel.VucutKitleEndeksi)}");
            Console.Write($"{typeof(double)}");
            Console.WriteLine($"{personel.VucutKitleEndeksi(1.84,78.8)}");
            Console.Write($"{nameof(personel.VucutKitleEndeksi)}");
            Console.Write($"{typeof(float)}");





        }


    }
}
