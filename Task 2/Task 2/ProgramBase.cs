using System.Collections.Generic;
using Task_2.Models;

namespace Task_2
{
    public class ProgramBase
    {

        public static void Main(string[] args)
        {
            // Person tipinden listimiz var.
            // Maashi 1000-den cox olan personlarin ad, soyad ve addresini gosteren ve parametr olaraq predicate qebul  eden method yazin.
            //============================================================================================================================

            List<Person> emp = new List<Person>();
            emp.Add(new Person { FullName = "Residli Nicat", Adress = "Ehmedli", Salary = 800 });
            emp.Add(new Person { FullName = "Nurlanli Resah", Adress = "Sahil", Salary = 1000 });
            emp.Add(new Person { FullName = "Babayev Yaver", Adress = "Suraxani", Salary = 500 });
            emp.Add(new Person { FullName = "Eliyeva Guler", Adress = "Nizami", Salary = 1800 });

        }
    }
}