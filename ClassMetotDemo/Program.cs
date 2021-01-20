using System;

namespace ClassMetotDemo
{
	class Program
	{
		static void Main(string[] args)
		{




			Musteri musteri1 = new Musteri();
			musteri1.Id = 12;
			musteri1.Ad = "yiğit";
			musteri1.Soyad = "egemen";
			musteri1.Yas = 24;

			Musteri musteri2 = new Musteri();
			musteri2.Id = 13;
			musteri2.Ad = "ayşe";
			musteri2.Soyad = "yılmaz";
			musteri2.Yas = 19;

			Musteri musteri3 = new Musteri();
			musteri3.Id = 18;
			musteri3.Ad = "Tolga";
			musteri3.Soyad = "erdem";
			musteri3.Yas = 35;


			Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
			Console.WriteLine("Müşteri Listesi");
			Console.WriteLine("__________________________");
			foreach (var musteri in musteriler) 
			{
				
				Console.WriteLine("Müşteri Id : " + musteri.Id);
				Console.WriteLine("Adı : " + musteri.Ad);
				Console.WriteLine("Soyadı : " + musteri.Soyad);
				Console.WriteLine("Yaşı : " + musteri.Yas);
				Console.WriteLine();
				
			}


			MusteriManager musteriManager = new MusteriManager();
			musteriManager.Add(musteri1);
			Console.WriteLine();
			musteriManager.Delete(musteri2);
			Console.WriteLine();
			musteriManager.Updated(musteri3);
			Console.WriteLine();


			Musteri[] musteriler2 = new Musteri[] { musteri1,musteri3 };
			Console.WriteLine("Güncel Müşteri Listesi");
			Console.WriteLine("__________________________");
			foreach (var musteri in musteriler2)
			{
				
				Console.WriteLine("Müşteri Id : " + musteri.Id);
				Console.WriteLine("Adı : " + musteri.Ad);
				Console.WriteLine("Soyadı : " + musteri.Soyad);
				Console.WriteLine("Yaşı : " + musteri.Yas);
				Console.WriteLine();

			}


		}
	}
}
