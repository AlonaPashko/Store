using Store.Enums;
using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Store.Interfaces;

namespace Store.Products
{
    internal class Meat : Product, IMeat
    {
        public Meat(string name, double price) : base(name, price) { }

        public Types MeatType { get; set; }
        public Category MeatCategory { get; set; }
        public double Weight { get; set; }

        //ctros

        public override string ToString()
        {
            return base.ToString() + " Type: " + MeatType + " Category: " + MeatCategory;
        }
        public override bool Equals(object? otherMeat)
        {
            return Name.Equals(((Meat)otherMeat).Name) &&
                MeatType.Equals(((Meat)otherMeat).MeatType) &&
                MeatCategory.Equals(((Meat)otherMeat).MeatCategory) &&
                Price.Equals(((Meat)otherMeat).Price);
        }
        //public override double ChangePrice(int rate)
        //{
        //    Console.WriteLine("Enter your category");
        //    int userCategory = int.Parse(Console.ReadLine());
        //    {
        //        Console.WriteLine("Wrong input");
        //    }
        //    Category category;
        //    category = (Category)Enum.GetValues(typeof(Category)).GetValue(userCategory - 1);

        //    switch (category)
        //    {
        //        case Category.Extra:
        //            Price = Price + Price * rate / 100.0 + (double)Category.Extra;
        //            break;
        //        case Category.Sort1:
        //            Price = Price + Price * rate / 100 + (double)Category.Sort1;
        //            break;
        //        default:
        //            Price = Price + Price * rate / 100 + (int)Category.Sort2;
        //            break;
        //    }
        //    return Price;
        //}


      
    }
}
