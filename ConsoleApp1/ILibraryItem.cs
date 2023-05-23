using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ILibraryItem
    {
        string Title { get; set; }
        DateTime DatePublished { get; set; }
        float Price { get; set; }
        string Language { get; set; }
        float Weight { get; set; }
        int NumberOfPages { get; set; }
        void DisplayData();

    }
}
