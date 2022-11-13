﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IPerishableProducts
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ExpirationDate { get; set; }

        public int CountDaysBeforeSpoilage();

        public string PrintDayBeforeSpoilage();
        
        public string PrintDateTime();
    }
}
