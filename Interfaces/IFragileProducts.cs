using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IFragileProducts : IProduct, IPrint
    {
        public string Type { get; set; }
        public string Marking { get; set; }

    }
}
