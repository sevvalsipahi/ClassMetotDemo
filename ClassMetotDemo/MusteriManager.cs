using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
	class MusteriManager
	{



        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri sisteme eklendi");
            Console.Write("Müşteri Id:" + musteri.Id+"  ");
            Console.WriteLine("Müşteri adı:"+musteri.Ad+ " "+musteri.Soyad);

        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri sistemden çıkarıldı");
            Console.Write("Müşteri Id:" + musteri.Id+"  ");
            Console.WriteLine("Müşteri adı:" + musteri.Ad +" "+ musteri.Soyad);
        }

        public void Updated(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri güncellendi");
            Console.Write("Müşteri Id:" + musteri.Id+" ");
            Console.WriteLine("Müşteri adı:" + musteri.Ad + " "+ musteri.Soyad);

        }

    }
}
