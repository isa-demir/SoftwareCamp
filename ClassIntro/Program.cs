using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.CourseName = "Mobile Programming With Flutter";
            kurs1.CourseInstructor = "Kasım Adalan";
            kurs1.ViewRating = 77;
            
            Kurs kurs2 = new Kurs() {
                CourseName = "Python Programming",
                CourseInstructor = "Engin Demiroğ",
                ViewRating = 88,
            };

            Kurs[] kurslar = { kurs1, kurs2};

            foreach (var item in kurslar)
            {
                Console.WriteLine("     Kurs Adı : " + item.CourseName);
                Console.WriteLine("Kurs Eğitmeni : " + item.CourseInstructor);
                Console.WriteLine("İzlenme Oranı : " + item.ViewRating);
                Console.WriteLine("-----------------------");
            }

        }
    }

    class Kurs
    {
        public string CourseName { get; set; }
        public string CourseInstructor { get; set; }
        public int ViewRating { get; set; }
    }
}
