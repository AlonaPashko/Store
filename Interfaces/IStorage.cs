using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IStorage
    {
        public List<IProduct> Products { get; set; }
       
        public List<IProduct> Add(IProduct product);
        public List<IProduct> Remove(IProduct product);
        
    }
}
