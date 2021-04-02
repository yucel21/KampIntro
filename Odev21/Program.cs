using System;

namespace Odev21
{
    class Program
    {
        static void Main(string[] args)
        {
            urun model1 = new urun();
            model1.pcAdi = "MSI";
            model1.ramGb = 16;
            model1.isletimSistemi = "Linux";
            model1.ekranKarti = "NVidia";

            urun model2 = new urun();
            model2.pcAdi = "Asus";
            model2.ramGb = 12;
            model2.isletimSistemi = "Windows 10";
            model2.ekranKarti = "NVidia GeForce";

            urun model3 = new urun();
            model3.pcAdi = "iMac";
            model3.ramGb = 8;
            model3.isletimSistemi = "macOS";
            model3.ekranKarti = "Intel Iris Plus Graphics 640";



            urun[] modeller = new urun[] { model1, model2, model3 };

            foreach (urun model in modeller)
            {
                Console.WriteLine(model.pcAdi + " : " +model.ramGb + " gb ram " + 
                    model.isletimSistemi + " "+ model.ekranKarti);
            }
        }

    }
    class urun
    {
        public string pcAdi { get; set; }
        public string isletimSistemi { get; set; }
        public int ramGb { get; set; }
        public string ekranKarti { get; set; }
    }

}
