using System;

namespace EcommerceSearchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101,"Keyboard","Electronics"),
                new Product(102,"Laptop","Electronics"),
                new Product(103,"Mobile","Electronics"),
                new Product(104,"Mouse","Electronics"),
                new Product(105,"Printer","Electronics")
            };

            Console.WriteLine("----- Linear Search -----");

            Product linearResult = SearchOperations.LinearSearch(products, "Mouse");

            if (linearResult != null)
            {
                Console.WriteLine($"Found: {linearResult.ProductName}");
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }

            Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

            Console.WriteLine();

            Console.WriteLine("----- Binary Search -----");

            Product binaryResult = SearchOperations.BinarySearch(products, "Mouse");

            if (binaryResult != null)
            {
                Console.WriteLine($"Found: {binaryResult.ProductName}");
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }

            Console.ReadLine();
        }
    }
}