using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    internal abstract class Decorator : IBuy
    {
        public IBuy buy;
        
        public Decorator(IBuy buy)
        {
            this.buy = buy;
        }

        public abstract double ProductPriceSum { get; }

        public abstract void AddProduct(Product product);
        
    }
}
