using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IStorage
    {
        public int Amount { get; set; }
        public double TotalPrice { get; set; }
    }
}
