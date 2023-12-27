namespace lab2v7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the musical catalog!");
            Console.WriteLine("Type one of commands of commands:");
            Console.WriteLine("'list' to display all compositions");
            Console.WriteLine("'search' to go find items in catalog");
            Console.WriteLine("add' add a composition to list");
            Console.WriteLine("'del' to delete composition from list");
            Console.WriteLine("'exit' to exit");

            Catalog catalog = new Catalog();

            while (true)
            {
                Console.Write("Enter command: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "search":
                        Console.Write("Enter criteria: ");
                        string searchCriteria = Console.ReadLine();
                        List<Composition> searchResults = catalog.Search(searchCriteria);
                        Console.WriteLine("Results:");
                        foreach (var result in searchResults)
                        {
                            Console.WriteLine(result);
                        }
                        break;

                    case "list":
                        catalog.DisplayAllCompositions();
                        break;

                    case "add":
                        Console.Write("Enter author's name: ");
                        string artist = Console.ReadLine();
                        Console.Write("Enter composition name: ");
                        string title = Console.ReadLine();

                        Composition newComposition = new Composition { Artist = artist, Title = title };
                        catalog.AddComposition(newComposition);
                        Console.WriteLine("Done.");
                        break;

                    case "del":
                        Console.Write("Enter composition name to remove: ");
                        string titleToDelete = Console.ReadLine();
                        Console.Write("Enter composition' author name to remove: ");
                        string artistToDelete = Console.ReadLine();

                        Composition compositionToDelete = catalog.Search(artistToDelete, titleToDelete).FirstOrDefault();

                        if (compositionToDelete != null)
                        {
                            catalog.RemoveComposition(compositionToDelete);
                            Console.WriteLine("Composition deleted.");
                        }
                        else
                        {
                            Console.WriteLine("Composition not found.");
                        }
                        break;

                    case "exit":
                        Console.WriteLine("Exiting....");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Inccorect command. Try again");
                        break;
                }
            }
        }
    }
}