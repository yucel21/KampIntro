using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do not repeat yourself
            //type safety - tip güvenliği
            //işlemlerden sonra ; kullanmak zorundayız
            //tek tırnakla string yazılmaz

            string kategoriEtiketi = "Kategori"; //alyas yani takma isim
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");

            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }            
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            
            Console.WriteLine(kategoriEtiketi);




            
        }
    }
}
