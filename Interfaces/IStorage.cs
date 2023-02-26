using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IStorage
    {
        public Dictionary<IProduct, int> StorageProducts { get; set; }
       
        public void Add(IProduct product);
        public void Remove(IProduct product);
        
    }
}
