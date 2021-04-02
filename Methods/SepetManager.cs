using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming Convention
        //syntax

        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + product.Adi);

        }

        public void Ekle2(string productAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + productAdi);


        }


    }
}
