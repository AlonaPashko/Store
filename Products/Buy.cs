using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    public class Buy : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Producent { get; set; }
        public int BoughtNumber { get; set; }

        public Buy() : this("", 0.0, "", 0) { }

        public Buy(string name, double price, string producent, int boughtNumber)
        {
            Name = name;
            Price = price;
            Producent = producent;
            BoughtNumber = boughtNumber;
        }
        public override string ToString()
        {
            return string.Format("Product: " + Name + " produced in " + Producent + " Numbers: "
                + BoughtNumber + " Price: " + Price);
        }
        public override bool Equals(object? otherBuy)
        {
            return Name.Equals(((Buy)otherBuy).Name) &&
                Price.Equals(((Buy)otherBuy).Price) &&
                Producer.Equals(((Buy)otherBuy).Producent) &&
                BoughtNumber.Equals(((Buy)otherBuy).BoughtNumber);
        }
    }
}
