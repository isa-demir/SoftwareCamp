using System;

namespace OpenClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    //KÖTÜ KOD
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public bool InsertIntoEmployeeTable(Employee em)
        {
            // Employee Tablosuna kayıt.
            return true;
        }
    }
    public class RaporOlusturma
    {
        public string RaporTipi { get; set; }
        public void RaporOlustur(Employee em)
        {
            if (RaporTipi == "CRS")
            {
                // Crystal Report ile rapor oluştur
            }
            if (RaporTipi == "PDF")
            {
                // PDF formatında rapor oluştur
            }
        }
    }
}
