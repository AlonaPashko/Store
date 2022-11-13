using Store.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
    internal class ExpiredProducts
    {
        public List<Product> ExpiredGoods { get; set; }

        public ExpiredProducts() : this(new List<Product>()) { }

        public ExpiredProducts(List<Product> expiredGoods)
        {
            ExpiredGoods = expiredGoods;
        }
        
        public List<Product> AddExpireProduct(Product product)
        {
            ExpiredGoods.Add(product);
            return ExpiredGoods;
        }

        public string PrintExpiredGoods()
        {
            string expairedGoods = "";
            for (int i = 0; i < ExpiredGoods.Count; i++)
            {
                expairedGoods += ExpiredGoods[i].ToString() + "\n";
            }
            return expairedGoods;
        }

        public override string ToString()
        {
            return "Expaired Goods:\n" + PrintExpiredGoods();
        }
    }
}
