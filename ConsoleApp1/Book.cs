using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book:LibraryItem
    {
        private string ISBN { get; set; }
        public string Genre { get; set; }
        public bool NationalBookAward { get; set; } // did the book receive the National Book Award
        public Author Author;
        public int? Edition { get; set; }

        public Book() { }
        public Book(
            string Title,
            DateTime DatePublished,
            float Price, 
            string Language, 
            float Weight, 
            int NumberOfPages,
            string ISBN, 
            string Genre, 
            bool NationalBookAward, 
            Author Author, 
            int? Edition = null)
        {
            this.Title = Title;
            this.DatePublished = DatePublished;
            this.Price = Price;
            this.Language = Language;
            this.Weight = Weight; // in grams
            this.NumberOfPages = NumberOfPages;
            this.ISBN = ISBN;
            this.Genre = Genre;
            this.NationalBookAward = NationalBookAward;
            this.Author = Author;
            this.Edition = Edition;
        }

    }
}
