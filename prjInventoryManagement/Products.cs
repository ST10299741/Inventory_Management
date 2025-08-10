using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    public class Products
    {
        public int ID, Quantity, Price, Result;
        public string Name;

        public Products(int id, int quantity, int price, string name, int Result)
        {
            this.ID = id;
            this.Quantity = quantity;
            this.Price = price;
            this.Name = name;
            this.Result = 0;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return ID;
                else if (index == 1)
                    return Quantity;
                else if (index == 2)
                    return Price;
                else if (index == 3)
                    return Name;
                else if (index == 4)
                    return Result;
                return null;
            }
            set
            {
                if (index == 0 )
                    this.ID = (int)value;
                else if (index == 1)
                    this.Quantity = (int)value;
                else if (index == 2)
                    this.Price = (int)value;
                else if (index == 3)
                    this.Name = (string)(value);
                else if (index == 4)
                    this.Result = (int)value;
            }
        }

        public object this[string atrrCustomer]
        {
            get
            {
                if (atrrCustomer == "ID")
                    return ID;
                else if (atrrCustomer == "Quantity")
                    return Quantity;
                else if (atrrCustomer == "Price")
                    return Price;
                else if (atrrCustomer == "Name")
                    return Name;
                else if (atrrCustomer == "Result")
                    return Result;
                return null;
            }
            set
            {
                if (atrrCustomer == "ID")
                    this.ID = (int)value;
                else if (atrrCustomer == "Quantity")
                    this.Quantity = (int)value;
                else if (atrrCustomer == "Price")
                    this.Price = (int)value;
                else if (atrrCustomer == "Name")
                    this.Name = (string)value;
                else if (atrrCustomer == "Result")
                    this.Result = (int)value;
            }
        }

    }
}
