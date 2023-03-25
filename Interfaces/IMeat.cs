using Store.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IMeat : IMaterialProduct
    {
        public Types MeatType { get; set; }
        public Category MeatCategory { get; set; }
        public double Weight { get; set; }
    }
}
