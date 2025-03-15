using System.Collections.Generic;
using System.Text;
namespace Question2;

class Program
{
    static void Main(string[] args)
    {
        SinglyLinkedList<Vehicle> list = new SinglyLinkedList<Vehicle>();

        string filePath = "/Users/yoonmin/Desktop/Assignment/Question2/auto-mpg.csv";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
            
                while ((line = reader.ReadLine()) != null)
                {
                    string[] columns = line.Split(',');

                
                    if (columns.Length >= 7)
                    {
                        Vehicle vehicle = new Vehicle(
                            columns[0], 
                            columns[1], 
                            columns[3], 
                            columns[4], 
                            columns[5], 
                            columns[6], 
                            columns[columns.Length - 1]

                        ) ;
                        list.AddLast(vehicle);
                       
                    }
                }
                list.RemoveFirst();
            }



        Console.WriteLine(list.ToString());

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

}

