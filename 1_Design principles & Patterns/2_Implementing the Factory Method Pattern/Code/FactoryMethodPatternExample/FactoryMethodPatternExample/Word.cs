using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample_
{
    public class Word : IDocument
    {
        private string Title;
        private string Content;

        public void Create()
        {
            Console.WriteLine("Opening Word document...");
        }

        public void Initialize()
        {
            Console.Write("Enter title for Word document: ");
            Title = Console.ReadLine();
            Console.Write("Enter content for Word document: ");
            Content = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine("\nTitle: " + Title);
            Console.WriteLine("Content:\n" + Content);
        }
    }
}
