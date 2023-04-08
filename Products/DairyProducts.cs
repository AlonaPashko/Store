using Store.FileOperation;
using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Store.Products
{
   
    internal class DairyProducts : Product, IPerishableProducts
    {
        public DateTime ExpirationDate { get; set; }
        
        public DairyProducts(string name, double price) : base(name, price) { }

        public DairyProducts()
        {
            ExpirationDate = DateTime.Now;
        }
        public DairyProducts(string name, double price, DateTime date)
        {
            Name = name;
            Price = price;
            ExpirationDate = date;
        }
        public bool IsNormalDate()
        {
            if (ExpirationDate <= DateTime.Now) { return false; }
            return true;
        }
        public void PrintExpertise()
        {
            if(IsNormalDate()) { Console.WriteLine("This is a normal product"); }
            else { Console.WriteLine("This is a bad product"); }
        }
      
        public override string ToString()
        {
            return Name + " - " + Price.ToString() + " " + ExpirationDate.ToString("yyyy-MM-dd");
        }
        
        
    }
}
