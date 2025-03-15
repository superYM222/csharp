using System;
using System.Collections.ObjectModel;

namespace Question1
{
	static class ExtentionObservvableCollecrion
	{

        public static void AddAll<T>(this ObservableCollection<T> collection, List<T> list)
        {
            foreach (var item in list)
            {
                collection.Add(item);
            }
        }
        public static void RemoveAll<T>(this ObservableCollection<T> collection, List<T> list)
        {
            foreach (var item in list)
            {
                collection.Remove(item);
            }
        }
        public static void PrintAll<T>(this ObservableCollection<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write(string.Join(" , ", item + " "));
            }
            Console.WriteLine();
        }
    }
}

