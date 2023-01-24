using System;

namespace SingleResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir class bir sorumluluk almalı yani bir class’ın isviçre çakısı
            //gibi bir sürü görevi, özelliği olmamalıdır.
            Console.WriteLine("Hello World!");
        }
    }

    //KÖTÜ KOD
    /*
     * Aşağıdaki kod ta “Employee” sınıfı 2 sorumluluk alıyor, biri çalışan
     * veritabanı işlemlerinin sorumluluğunu üstleniyor, diğeri ise çalışanların
     * raporlarını oluşturuyor. Employee sınıfı, rapor oluşturma sorumluluğunu
     * üstlenmemelidir, çünkü müşteriniz sizden raporu Excel’de veya başka bir 
     * dosya türünde raporlama isteme olasılığı olduğunu düşünürsek, bu class’ın 
     * değiştirilmesi gerekecektir.
     * 
     * Bu nedenle, SRP prensibine göre, bir class bir sorumluluk almalı,
     * bu yüzden rapor oluşturma işlemi için farklı bir class yazmalıyız 
     * ve rapor oluşturma class’ındaki herhangi bir değişiklik “Employee” 
     * class’ını etkilememelidir.
     */
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public bool InsertIntoEmployeeTable(Employee em)
        {
            // Employee Tablosuna kayıt.
            return true;
        }
        //public void RaporOlustur(Employee em)    -> bu fonksiyon aşağıya taşındı.
        //{
        //    // Crystal report kullanılarak rapor oluşturma.
        //}
    }
    class RaporOlusturma
    {
        public void RaporOlustur(Employee em)
        {
            // Crystal report kullanılarak rapor oluşturma.
        }
    }
}
