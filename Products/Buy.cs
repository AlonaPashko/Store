using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    internal class Buy : Colleague, IBuy
    {
        private List<Product> products;
        private double productPriceSum;

        public List<Product> ProductList => new List<Product>(products);
        
        public double ProductPriceSum
        {
            get => productPriceSum;
            private set => productPriceSum = value;
        }
        public Buy() : this("") { }
        
        public Buy(string msg) : this(new List<Product>()) { }

        public Buy(IEnumerable<Product> products)
        {
            this.products = new List<Product>(products);
            ProductPriceSum = products.Select(x => x.Price).Sum();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            if (obj is Buy other && other.ProductList.Count == this.ProductList.Count)
            {
                for (int i = 0; i < ProductList.Count; i++)
                {
                    if (!Equals(ProductList[i], other.ProductList[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string line = "";
            for (int i = 0; i < ProductList.Count; i++)
            {
                line += "Name: " + ProductList[i].Name + " Price: " + ProductList[i].Price + "\n"; 
            }
            return line;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void UpdateProductPriceSum(string msg)
        {
            ProductPriceSum = products.Select(x => x.Price).Sum();
        }

        public override void Send(string msg)
        {
            mediator.Send(this.ToString(),this);
        }

        public override void Notify(string msg)
        {
            if (msg == "Print check, please")
            {
                Console.WriteLine("Buy successfully");
                mediator.Send("OK", this);
            }
            else
            {
                Console.WriteLine("Smth was wrong");
            }
        }

        //    public double ChangePrice(int rate)
        //    {
        //        Price = (double)(Price * rate / 100.0);
        //        return Price;
        //    }
    }
}
