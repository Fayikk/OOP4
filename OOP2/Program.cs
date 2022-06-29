using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Fayik";
            musteri1.Soyadi = "Veznedaroglu";
            musteri1.TcNo = "12345678910";

            TuzelMUsteri musteri2 = new TuzelMUsteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.VergiNo = "123456";
            musteri2.SirketAdi = "lagaluga";
            //new gördüğümüz yerde ,bellekteki referans numarası aklımıza gelmeli

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMUsteri();
            


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            //SOLID prensiplerinden I harfi
        }
    }
}
