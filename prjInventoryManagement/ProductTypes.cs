using System;  
using System.Collections.Generic;  
using System.Linq;  

namespace prjInventoryManagement
{
    public class ProductTypes : List<Products>
    {
        // Anonymous type displaying product names and prices using LINQ  
        public void DisplayProductNamesAndPrices()
        {
            /*Microsoft-Learn. 2025(A)
            The anonymous type here of productDetails is being anishiated from the new followed {};
            It is used to create an object with properties Name and Price, which are selected from each product in the list.
            ---
            Microsoft - Learn. 2025(B)
            lINQ {Language Integrated Query} is a powerful feature within C# that allows you to query collections in a more 
            readable, this can be seen on Line 19 making use of the Keyword Select.
            In essense, LINQ proveds SQL-like query capabilities directly in C# code, this allows better data manipulation and retrieval.
             */
            var productDetails = this.Select(product => new
            {
                product.Name,
                product.Price
            });

            foreach (var detail in productDetails)
            {
                Console.WriteLine($"Name: {detail.Name}, Price: {detail.Price}");
            }
        }
    }
}


/* References 
Author. year. Title. version. [Sourcecode/ computer program]. url. (when it was accessed)
---
Microsoft-Learn. 2025(A). Anonymous types. Net8.0. [Soursecode]. https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types. (Accessed on 11 August 2025).

Microsoft-Learn. 2025(B). Language Integrated Query (LINQ). Net8.0. [Soursecode]. https://learn.microsoft.com/en-us/dotnet/csharp/linq/. (Accessed on 11 August 2025).

 */