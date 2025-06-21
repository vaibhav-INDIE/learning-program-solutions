using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample_
{
    public class PDF : IDocument
    {
        private string Title;
        private string Paragraph;

        public void Create()
        {
            Console.WriteLine("Creating PDF document...");
        }

        public void Initialize()
        {
            Console.Write("Enter title for PDF document: ");
            Title = Console.ReadLine();
            Console.Write("Enter paragraph content for PDF: ");
            Paragraph = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine("\nPDF Title: " + Title);
            Console.WriteLine("Content:\n" + Paragraph);
        }
    }
}
