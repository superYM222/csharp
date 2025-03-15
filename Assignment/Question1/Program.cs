using System.Collections.ObjectModel;

namespace Question1;

class Program
{
    static void Main(string[] args)
    {
        ObservableCollection<int> collection = new ObservableCollection<int>() { 1, 2, 3, 4, 5 };
        Console.Write("Collection: ");
        collection.PrintAll();
        List<int> list = new List<int>() { 100, 200, 300 };
        Console.Write("Add List: ");
        collection.AddAll(list);
        collection.PrintAll();
        Console.Write("Remove List: ");
        collection.RemoveAll(list);
        collection.PrintAll();
    }
}

