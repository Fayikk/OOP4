using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {   //Burada method injection kullanıyoruz
        //IkrediManager hepsinin referansını tutuyordur.
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
