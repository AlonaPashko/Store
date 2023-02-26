﻿using Store.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IHouseholdChemicals : IProduct
    {
        public AggregateState State { get; set; }
    }
}
