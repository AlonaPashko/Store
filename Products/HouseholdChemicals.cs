using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    internal class HouseholdChemicals : Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public HouseholdChemicals() : this("", 0.0) { }

        public HouseholdChemicals(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return "Category: household chemicals. Name: " + Name +
                ". Price: " + Price.ToString();
        }
    }
}
