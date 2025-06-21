using FactoryMethodPatternExample_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Do you want to run test mode? (y/n): ");
        string choice = Console.ReadLine();

        if (choice.Equals("y", StringComparison.OrdinalIgnoreCase))
        {
            TestDocumentFactory.RunTest();
        }
        else
        {
            Console.Write("Enter document type (WORD / EXCEL / PDF): ");
            string type = Console.ReadLine();

            DocumentFactory.CreateDocument(type);
        }
    }
}