using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //IkrediManager hepsinin referansını tutuyordur.
        public void BasvuruYap(IKrediManager krediManager)
        {
            //başvuran bilgilerini değerlendirme
            krediManager.Hesapla();

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
