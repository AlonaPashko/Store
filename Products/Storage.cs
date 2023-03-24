using Store.FileOperation;
using Store.Interfaces;
using Store.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Store.Products
{
    internal class Storage : IStorage
    {
        public List<IProduct> Products { get; set; }

        public Storage()
        {
            Products = new List<IProduct>();
        }
        public Storage(string filePath)
        {
            Products = ParseFromFile(filePath);
        }

        public void Add(IProduct product)
        {
            Products.Add(product);
        }

        public void Remove(IProduct product)
        {
            Products.Remove(product);
        }
        public List<IProduct> ParseFromFile(string filePath)
        {
            FileReader reader = new FileReader(filePath);
            List<string> productsStr = reader.ReadExpression();
            List<IProduct> productsList = new List<IProduct>();

            for (int i = 0; i < productsStr.Count; i++)
            {
                string[] arr = productsStr[i].Split("-", StringSplitOptions.RemoveEmptyEntries);
                Product product = new Product{ Name = arr[0], Price = double.Parse(arr[1]) };
                productsList.Add(product);
            }
            return productsList;
        }
        public override string ToString()
        {
            return Print.PrintList(Products);
        }
    }
}
