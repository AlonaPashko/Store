using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    internal class Storage
    {
        private int productsAmount;
        private double totalWeight;
        private double totalPrice;
        private List<Product> products;

        public int ProductsAmount { get; set; }
        public double TotalWeight { get; set; }
        public double TotalPrice { get; set; }
        public List<Product> Products;


        public Storage() : this(new List<Product> { new Product() }) { }

        public Storage(List<Product> products)
        {
            Products = products;
            ProductsAmount = Products.Count();
            TotalWeight = SetTotalWeight();
            TotalPrice = SetTotalPrice();

        }
        private double SetTotalWeight()
        {
            double totalWeight = 0.0;
            foreach (Product product in Products)
            {
                totalWeight += product.Weight;
            }
            return totalWeight;
        }
        private double SetTotalPrice()
        {
            double totalPrice = 0.0;
            foreach (Product product in Products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }

        public override string ToString()
        {
            return string.Format(PrintList());
        }
        public override bool Equals(object? otherStorage)
        {
            return ProductsAmount.Equals(((Storage)otherStorage).ProductsAmount) &&
                TotalWeight.Equals(((Storage)otherStorage).TotalWeight) &&
                TotalPrice.Equals(((Storage)otherStorage).TotalPrice);
        }

        public void Initialization(string name, double weight, double price)
        {
            Product product = new Product(name, price, weight);
        }

        public string PrintList()
        {
            string line = "";
            foreach (Product product in Products)
            {
                line += product + "\n";
            }
            return line;
        }

        public void ChangePrice(int rate)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Products[i].Price = (double)Products[i].Price + Products[i].Price * rate / 100;
            }
        }
        public Product this[int index]
        {
            get
            {
                if (index >= 0 && index < Products.Count)
                {
                    return Products[index];
                }
                else throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < Products.Count)
                {
                    Products[index] = value;
                }
                else throw new ArgumentOutOfRangeException();
            }
        }

        public void Parse(string str)//parse string into class fields
        {
            string[] array = str.Split(' ');
            productsAmount = int.Parse(array[0]);
            TotalWeight = double.Parse(array[1]);
            TotalPrice = double.Parse(array[2]);
        }
        
        public bool IsCorrectProduct(Product product)
        {
            if (product.Weight != 0 && product.Price != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
