using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class LibraryItem : ILibraryItem
    {
        protected Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public float Price { get; set; }
        public string Language { get; set; }
        public float Weight { get; set; }
        public int NumberOfPages { get; set; }
        public virtual void DisplayData()
        {
            Console.WriteLine($"LibraryItem DisplayData\nTitle: {Title}\nDate Published: {DatePublished}\nPrice: {Price}\nLanguage: {Language}\nWeight: {Weight}\nNumber of pages: {NumberOfPages}\n");
        }
    }
}

