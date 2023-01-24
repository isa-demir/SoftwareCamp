using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            KonutKrediManager konutKredi = new KonutKrediManager();
            
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager);
            //basvuruManager.BasvuruYap(konutKredi);

            List<IKrediManager> krediler = new List<IKrediManager>() { 
                ihtiyacKrediManager, tasitKrediManager,
            };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);
            //basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);

        }
    }
}
