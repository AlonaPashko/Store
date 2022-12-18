using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Store.Products
{
    internal class DairyProducts : Product, IPerishableProducts
    {
        public DateTime ExpirationDate { get; set; }

        public int CountDaysBeforeSpoilage()
        {
            return 0;
        }

        public string PrintDayBeforeSpoilage()
        {
            return CountDaysBeforeSpoilage().ToString();
        }
    }
}
