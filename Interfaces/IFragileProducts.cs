using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IFragileGoods
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public string Marking { get; set; }

        public string PrintType();
    }
}
