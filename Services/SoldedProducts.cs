using Store.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
    internal class SoldedProducts
    {
        public List<Product> SoldedGoods { get; set; }

        public SoldedProducts() : this(new List<Product>()) { }

        public SoldedProducts(List<Product> soldedGoods)
        {
            SoldedGoods = soldedGoods;
        }
        public List<Product> AddSoldProduct(Product product)
        {
            SoldedGoods.Add(product);
            return SoldedGoods;
        }
        
        public string PrintSoldedGoods()
        {
            string soldedGoods = "";
            for (int i = 0; i < SoldedGoods.Count; i++)
            {
                soldedGoods += SoldedGoods[i].ToString() + "\n";
            }
            return soldedGoods;
        }

        public override string ToString()
        {
            return "Solded Goods:\n" + PrintSoldedGoods();
        }
    }
}

