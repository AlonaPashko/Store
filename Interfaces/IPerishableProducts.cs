using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IPerishableProducts : IFood
    {
        public DateTime ExpirationDate { get; set; }

        public int CountDaysBeforeSpoilage();
      
    }
}
