using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    internal abstract class Colleague
    {
        protected IBuyMediator mediator;

        public void SetMediator(IBuyMediator mediator)
        {
            this.mediator = mediator;
        }
        public abstract void Send(string msg);

        public abstract void Notify(string msg);
    }
}
