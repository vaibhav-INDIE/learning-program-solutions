using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample_
{
    public class DocumentFactory
    {
        public static IDocument CreateDocument(string type)
        {
            IDocument doc = null;

            if (type.Equals("WORD", StringComparison.OrdinalIgnoreCase))
                doc = new Word();
            else if (type.Equals("EXCEL", StringComparison.OrdinalIgnoreCase))
                doc = new Excel();
            else if (type.Equals("PDF", StringComparison.OrdinalIgnoreCase))
                doc = new PDF();

            if (doc != null)
            {
                doc.Create();
                doc.Initialize();
                doc.Show();
            }
            else
            {
                Console.WriteLine("Invalid document type.");
            }

            return doc;
        }
    }
}
