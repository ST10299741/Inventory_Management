using System.Diagnostics;
using System.Xml.Linq;

namespace prjInventoryManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Products product = new Products(0, 34, 4000, "Roger", 136000); // Creating a product instance

            // Using indexers to access properties
            ProductTypes productList = new ProductTypes
    {
        new Products(1, 10, 100, "Item1", 1000), // Creating a list of products
        new Products(2, 20, 200, "Item2", 4000),
        new Products(3, 2,  50,  "Item3", 100)
    };

            // Calculate total and print it
            int totalValue = ProductExtensions.CalculateTotalValue(productList);
            Console.WriteLine($"Total value of all products: {totalValue}");

            //Check if two list items are the same reference and print it
            bool Ref = object.ReferenceEquals(productList[0], productList[1]);
            Console.WriteLine($"First and second are the same reference? {Ref}");

            // Filter low stock
            int threshold = 5;
            var lowStock = productList.FilterLowStock(threshold);
            Console.WriteLine($"\nLow stock (Quantity < {threshold}):");
            foreach (var p in lowStock)
                Console.WriteLine($"{p.Name} (Qty: {p.Quantity})");

            // Anonymous types via LINQ {Name + Price}
            Console.WriteLine("\nProduct names and prices:");
            productList.DisplayProductNamesAndPrices();

            // Display a single product
            Console.WriteLine("\nProduct Details:");
            Console.WriteLine($"ID: {product.ID}, Quantity: {product.Quantity}, Price: {product.Price}, Name: {product.Name}, Total Value (Result): {product.Result}");

            Console.WriteLine("\nProduct List Details:");
            foreach (var item in productList)
                Console.WriteLine($"ID: {item.ID}, Quantity: {item.Quantity}, Price: {item.Price}, Name: {item.Name}, Total Value (Result): {item.Result}");

            Console.ReadKey();
        }
    }
}
