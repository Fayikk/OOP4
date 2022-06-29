using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IhtıyacKrediManager ıhtıyacKrediManager = new IhtıyacKrediManager();
            TaşıtKredisiManager taşıtKredisiManager = new TaşıtKredisiManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ıhtıyacKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager);
            //basvuruManager.BasvuruYap(taşıtKredisiManager);

            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtıyacKrediManager,taşıtKredisiManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
