using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    public static class ProductExtensions
    {
        // Extension method to calculate the total value of all products
        // Extension method on List<Products> to total value.
        /* GeeksforGeeks. 2025(A)
         * the list of products is passed as an argument to the extension method.
         */
        public static int CalculateTotalValue(this List<Products> products)
        {
            // Sum over Price * Quantity using a lambda expression.
            return products.Sum(product => product.Price * product.Quantity);
        }

        // Extension method to filter products that are low in stock  
        // Extension method on List<Products> to filter low stock.
        /*Microsoft.Learn. 2025(A)
         *  The extension method is defined on List<Products> and takes an integer threshold as a parameter.
         *  to indentify this as an extension method, the first parameter is prefixed with "this".
         */
        public static List<Products> FilterLowStock(this List<Products> products, int threshold)
        {
            // I Used a LINQ to filter products with Quantity less than the prameter refered as the threshold.
            return products.Where(product => product.Quantity < threshold).ToList();
        }
    }
}


/* References 
Author. year. Title. version. [Sourcecode/ computer program]. url. (when it was accessed)
---
GeeksforGeeks. 2025(A). C# List Class. Net8.0. [SourseCode]. https://www.geeksforgeeks.org/c-sharp/c-sharp-list-class/. (Accessed on 11 August 2025).

Microsoft.Learn. 2025(A). Extension members (C# Programming Guide). Net8.0. [SourseCode]. https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods. (Accessed on 11 August 2025).
*/