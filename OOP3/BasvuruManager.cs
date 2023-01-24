using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager kredi, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendir
            // ek işlemler
            //en son
            kredi.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var item in krediler)
            {
                item.Hesapla();
                
            }
        }
    }
}
