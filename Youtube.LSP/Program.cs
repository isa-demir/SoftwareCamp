using System;

namespace Youtube.LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var isa = new GercekMusteri {Id = 1, FirstName = "İsa", LastName = "Demir", TCNo = "212312" };
            var sirket = new TuzelMusteri { Id = 2, SirketAdi = "Demir A.Ş.", VergiNo = "12231434" };

        }
    }
    class Customer
    {
        public int Id { get; set; }
    }
    class GercekMusteri : Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TCNo { get; set; }
    }
    class TuzelMusteri : Customer
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
