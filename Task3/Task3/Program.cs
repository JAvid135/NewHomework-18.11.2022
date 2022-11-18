using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Task3.Models;

namespace Task3
{
    public class Program
    {
        public delegate void CheckAuthor(string author);
        static void Main(string[] args)
        {
           //Book tipinden listimiz olacaq. Authoru Nizami olan book-larin sayini gosteren ve predicate qebul eden method yazin.
           //===================================================================================================================

            List<Books> books = new List<Books>();
            books.Add(new Books { Author = "Nizami Ganjavi", BookName = "Khamsa of Nizami" });
            books.Add(new Books { Author = "Nizami Ganjavi", BookName = "Khosrow and Shirin" });
            books.Add(new Books { Author = "Nizami Ganjavi", BookName = "Layla and Majnun" });

            CheckBook(CheckBookAuthor, books);


        }

        public static bool CheckBookAuthor(string name)
        {
            return (name == "Nizami Ganjavi");
        }

        public static void CheckBook(Predicate<string> predicate, string[] booksData)
        {
            int count = 0;
            foreach (var item in booksData)
            {
                if (predicate(item))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

    }
}
