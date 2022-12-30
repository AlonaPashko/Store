using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Producent { get; set; }

        public double ChangePrice(int rate);
    }
}
