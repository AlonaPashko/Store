using Store.Exceptions;
using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    public class Product : IComparable
    {
        //public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        //public string Producent { get; set; }

        public Product() { }
        
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        
        public double ChangePrice(int rate)
        {
            return 0;
        }

        public int CompareTo(object? obj)
        {
            //int res = -1;

            //if (obj as Product == null)
            //{
            //    Console.WriteLine("NULL");
            //    return res;
            //}
            //return this.Name.CompareTo(((Product)obj).Name);
            return (obj as Product)?.Name.CompareTo(Name) ?? -1;
        }
       

    }
}
