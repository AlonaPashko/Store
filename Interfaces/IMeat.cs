using Store.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IMeat : IProduct, IPrint
    {
        public Types MeatType { get; set; }
        public Category MeatCategory { get; set; }
    }
}
