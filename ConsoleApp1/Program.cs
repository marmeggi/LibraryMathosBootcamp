using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Author object creation using constructor
            Author author1 = new Author("Ivo", "Andrić", new DateTime(1892, 10, 9), new DateTime(1975, 3, 13), "Dolac", "Bosnia and Herzegovina");
            // Magazine object creation using constructor
            Magazine magazin1= new Magazine(
                "Vogue",
                new DateTime(2023,1,5),
                2.29f,
                "English",
                1.79f,
                120,
                "Fashion",
                "Monthly");
            // Book object creation using constructor
            Book book1 = new Book(
                "Na Drini ćuprija",
                new DateTime(2013),
                5.50f, 
                "Serbian",
                1.27f,
                318,
                "9788673600444",
                "Novel", 
                false,
                author1);
            // Overriding example
            magazin1.DisplayData(); // displays Magazine data
            book1.DisplayData(); // displays LibraryItem data

            
            Console.ReadLine();
        }
    }
}
