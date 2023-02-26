using Store.FileOperation;
using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Store.Products
{
    internal class Storage : IStorage
    {
        public event RecyclingFileHandlerDelegate WriteProduct;

        private int productsAmount;
        private double totalPrice;

        public int ProductsAmount { get; set; }
        public double TotalPrice { get; set; }
        public Dictionary<IProduct, int> StorageProducts { get; set; }

        public override string ToString()
        {
            return "";
        }
        public override bool Equals(object? otherStorage)
        {
            return ProductsAmount.Equals(((Storage)otherStorage).ProductsAmount) &&
                TotalPrice.Equals(((Storage)otherStorage).TotalPrice);
        }

        

        
        //public Product this[int index] - indexer
        //{
        //    get
        //    {
        //        if (index >= 0 && index < Products.Count)
        //        {
        //            return Products[index];
        //        }
        //        else throw new ArgumentOutOfRangeException();
        //    }
        //    set
        //    {
        //        if (index >= 0 && index < Products.Count)
        //        {
        //            Products[index] = value;
        //        }
        //        else throw new ArgumentOutOfRangeException();
        //    }
        //}

        public void Parse(string str)//parse string into class fields
        {
            string[] array = str.Split(' ');
            productsAmount = int.Parse(array[0]);
            TotalPrice = double.Parse(array[2]);
        }

        public void Add(IProduct product)
        {
           //adding product to a storage
        }

        public void Remove(IProduct product)
        {
            //remove product from storage
        }

        //public bool IsCorrectProduct(Product product)
        //{
        //    if (product.Weight != 0 && product.Price != 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
