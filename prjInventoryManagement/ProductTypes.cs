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
