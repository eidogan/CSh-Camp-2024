using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();
            SelamVer(isim: "ebru");
            SelamVer();

            int sonuc = Topla(3,5);

            //diziler arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            
            ogrenciler=new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]); 
            }

            string[] sehirler1 = new[] { "ankara", "istanbul", "izmir"};
            string[] sehirler2 = new[] { "bursa", "antalya", "diyarbakır"};

            sehirler2 = sehirler1;
            sehirler1[0] = "adana";
            Console.WriteLine(sehirler2[0]);

            //reference types : array, interface, class, abstract
            //value types : int, double, bool
            //string aslında reference tip ama çalışma şekli value tip gibidir.

            /*
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2);
            */

            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demiroğ";
            person1.BirthYear = 1985;
            person1.Identity = 123;


            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> {"ankara 1","istanbul 1","izmir 1"};
            yeniSehirler1.Add(item: "adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);



            Console.ReadLine(); //konsolda bekleme yapar
        }

        static void SelamVer(string isim="noname")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc=sayi1+sayi2;
            Console.WriteLine("Toplam: " + sonuc.ToString());
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;

            Console.WriteLine(tutar * 1.18);

        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
