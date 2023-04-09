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

        public Utilization Util { get; set; }

        public Storage()
        {
            Products = new List<IProduct>();
            Util = new Utilization();
        }

        public Storage(string filePath) => Products = ParseFromFile(filePath);

        public event EventHandler AddingFreshProducts;

        public List<IProduct> Remove(IProduct product)
        {
            Products.Remove(product);
            return Products;
        }
        public List<IProduct> ParseFromFile(string filePath)
        {
            FileReader reader = new FileReader(filePath);
            List<string> productsStr = reader.ReadExpression();
            List<IProduct> productsList = new List<IProduct>();

            for (int i = 0; i < productsStr.Count; i++)
            {
                string[] arr = productsStr[i].Split("-", StringSplitOptions.RemoveEmptyEntries);
                Product product = new Product { Name = arr[0], Price = double.Parse(arr[1]) };
                productsList.Add(product);
            }
            return productsList;
        }
        public List<IProduct> Add(IProduct product)
        {
            if (product is DairyProducts)
            {
                if (!(product as DairyProducts).IsNormalDate())
                {
                    Util.Add(product);
                    Util.DoUtilizationFile(product);
                    OnAddingFreshProducts(EventArgs.Empty); return Products;
                }
            }
            Products.Add(product);
            return Products;
        }
        protected virtual void OnAddingFreshProducts(EventArgs e)
        {
            AddingFreshProducts?.Invoke(this, e);
        }
        
        public override string ToString()
        {
            return "\n" + Print.PrintList(Products) + "\nUtilization List:\n\n" +
                Print.PrintList(Util.UtilizationList);
        }
    }
}
