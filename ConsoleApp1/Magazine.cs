using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Magazine:LibraryItem
    {
        public string Type { get; set; }
        public string PublishingFrequency { get; set; } // daily, weekly, monthly etc.

        public Magazine() { }
        public Magazine( 
            string Title,
            DateTime DatePublished, 
            float Price,
            string Language,
            float Weight,  // in pounds
            int NumberOfPages,
            string Type, // fashion, sports, news, etc.
            string PublishingFrequency)
        {
            this.Title = Title;
            this.DatePublished = DatePublished; 
            this.Price = Price; 
            this.Language = Language;   
            this.Weight = Weight;   
            this.NumberOfPages = NumberOfPages; 
            this.Type = Type;
            this.PublishingFrequency = PublishingFrequency;
        }



        public override void DisplayData()
        {
            Console.WriteLine($"Magazine DisplayData\nType: {Type}\nPublishing Frequency: {PublishingFrequency}\n");
        }
    }
    
}