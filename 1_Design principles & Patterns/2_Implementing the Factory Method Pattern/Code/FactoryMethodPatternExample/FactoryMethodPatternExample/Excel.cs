using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample_
{
    public class Excel : IDocument
    {
        private string Title;
        private string[,] Table;

        public void Create()
        {
            Console.WriteLine("Making Excel document");
        }

        public void Initialize()
        {
            Console.Write("Enter title for Excel document: ");
            Title = Console.ReadLine();

            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            Table = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Enter row {i + 1} (space-separated): ");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < Math.Min(cols, values.Length); j++)
                {
                    Table[i, j] = values[j];
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("\nTitle: " + Title);
            Console.WriteLine("Table:");
            for (int i = 0; i < Table.GetLength(0); i++)
            {
                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    Console.Write((Table[i, j] ?? "") + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
