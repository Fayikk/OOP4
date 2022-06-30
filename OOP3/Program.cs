using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{//İnterfaceler referans tutucu olarak görev alırlar.
    internal class Program
    {
        static void Main(string[] args)
        {
            IhtıyacKrediManager ıhtıyacKrediManager = new IhtıyacKrediManager();
            TaşıtKredisiManager taşıtKredisiManager = new TaşıtKredisiManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            EsnafKredisiManager esnafKredisiManager = new EsnafKredisiManager();

            ILoggerService databaseloggerService = new DataBaseLoggerService();
            ILoggerService fileloggerservice = new FileLoggerService();
            ILoggerService SmsloggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ıhtıyacKrediManager);
            basvuruManager.BasvuruYap(konutKrediManager,databaseloggerService);
            basvuruManager.BasvuruYap(taşıtKredisiManager,fileloggerservice);
            basvuruManager.BasvuruYap(esnafKredisiManager, databaseloggerService);
            basvuruManager.BasvuruYap(ıhtıyacKrediManager, SmsloggerService);

            
            

            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtıyacKrediManager,taşıtKredisiManager};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
