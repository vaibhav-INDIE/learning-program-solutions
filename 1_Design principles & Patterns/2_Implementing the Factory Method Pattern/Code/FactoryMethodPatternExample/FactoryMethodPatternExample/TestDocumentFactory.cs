using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample_
{
    public class TestDocumentFactory
    {
        public static void RunTest()
        {
            Console.WriteLine("==== TESTING WORD DOCUMENT ====");
            IDocument word = new Word();
            word.Create();
            SimulateWordInput(word);
            word.Show();

            Console.WriteLine("\n==== TESTING EXCEL DOCUMENT ====");
            IDocument excel = new Excel();
            excel.Create();
            SimulateExcelInput(excel);
            excel.Show();

            Console.WriteLine("\n==== TESTING PDF DOCUMENT ====");
            IDocument pdf = new PDF();
            pdf.Create();
            SimulatePDFInput(pdf);
            pdf.Show();
        }

        private static void SimulateWordInput(IDocument doc)
        {
            if (doc is Word word)
            {
                typeof(Word).GetField("Title", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(word, "Test Word Title");
                typeof(Word).GetField("Content", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(word, "This is a test Word content.");
            }
        }

        private static void SimulateExcelInput(IDocument doc)
        {
            if (doc is Excel excel)
            {
                typeof(Excel).GetField("Title", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(excel, "Test Excel Title");

                string[,] table = new string[,]
                {
                    { "A1", "B1", "C1" },
                    { "A2", "B2", "C2" }
                };

                typeof(Excel).GetField("Table", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(excel, table);
            }
        }

        private static void SimulatePDFInput(IDocument doc)
        {
            if (doc is PDF pdf)
            {
                typeof(PDF).GetField("Title", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(pdf, "Test PDF Title");
                typeof(PDF).GetField("Paragraph", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(pdf, "This is a paragraph in a test PDF document.");
            }
        }
    }
}
