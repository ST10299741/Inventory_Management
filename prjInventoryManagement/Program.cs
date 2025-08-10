using System.Diagnostics;
using System.Xml.Linq;

namespace prjInventoryManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Renamed the first 'products' variable to 'product' to avoid CS0128.  
            Products product = new Products(0, 34, 4000, "Roger", 136000);

            // Renamed the second 'products' variable to 'productList' to avoid CS0128.  
            ProductTypes productList = new ProductTypes
                      {
                          new Products(1, 10, 100, "Item1", 1000),
                          new Products(2, 20, 200, "Item2", 4000)
                      };

            // Updated to pass 'productList' (a List<Products>) to avoid CS1503.  
            ProductExtensions.CalculateTotalValue(productList);

            // Updated to use the indexer to access a specific product in the list.  
            Products.ReferenceEquals(productList[0], productList[1]);

            // Display product details to the console.  
            Console.WriteLine("Product Details:");
            Console.WriteLine($"ID: {product.ID}, Quantity: {product.Quantity}, Price: {product.Price}, Name: {product.Name}, Total Value: {product.Result}");

            Console.WriteLine("\nProduct List Details:");
            foreach (var item in productList)
            {
                Console.WriteLine($"ID: {item.ID}, Quantity: {item.Quantity}, Price: {item.Price}, Name: {item.Name}, Total Value: {item.Result}");
            }
        }
    }
}
