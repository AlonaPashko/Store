using Store.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IBuyMediator
    {
        void Send(string msg, Colleague colleague);
    }
}
