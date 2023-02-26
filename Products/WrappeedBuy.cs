using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    internal class WrappeedBuy : Decorator
    {
        
        public WrappeedBuy(IBuy buy): base(buy) { }

        public override double ProductPriceSum => buy.ProductPriceSum;

        public override void AddProduct(Product product)
        {
            buy.AddProduct(product);
        }
        public string Wrap()
        {
            return "product wrapped\n";
        }
        public override string ToString()
        {
            return Wrap() + buy.ToString();
        }
    }
}
