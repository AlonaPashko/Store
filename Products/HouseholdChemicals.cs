using Store.Enums;
using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    internal class HouseholdChemicals : Product, IHouseholdChemicals
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public AggregateState State { get; set; }

        public HouseholdChemicals(): base() { }

        public HouseholdChemicals(string name, double price, AggregateState state)
        {
            Name = name;
            Price = price;
            State = state;
        }

        public override string ToString()
        {
            return "Category: household chemicals. Name: " + Name +
                ". Price: " + Price.ToString() + " State: " + State.ToString();
        }

      
    }
}
