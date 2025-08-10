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
        public static int CalculateTotalValue(this List<Products> products)
        {
            return products.Sum(product => product.Price * product.Quantity);
        }

        // Extension method to filter products that are low in stock  
        public static List<Products> FilterLowStock(this List<Products> products, int threshold)
        {
            return products.Where(product => product.Quantity < threshold).ToList();
        }
    }
}
