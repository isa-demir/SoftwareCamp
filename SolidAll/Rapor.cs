using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple
{
    //DOĞRU KULLANIM
    public abstract class Rapor
    {
        public int RaporId { get; set; }
        public string RaporAdi { get; set; }

        public abstract void RaporOlustur(Employee em);
    }

    class PDFRaporOlustur : Rapor
    {
        public override void RaporOlustur(Employee em)
        {
            Console.WriteLine(em.EmployeeName + " için pdf rapor oluşturuldu.!");
        }
    }
    class CloudRaporOlustur : Rapor
    {
        public override void RaporOlustur(Employee em)
        {
            Console.WriteLine(em.EmployeeName + " için cloud rapor oluşturuldu.!");
        }
    }
}
