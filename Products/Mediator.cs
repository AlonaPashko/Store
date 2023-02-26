using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    internal class Mediator : IBuyMediator
    {
        private Colleague colleague1;
        private Colleague colleague2;

        public void Send(string msg, Colleague colleague)
        {
            if (colleague is not null && colleague == colleague1)
            {
                colleague2?.Notify(msg);
            }
            else if (colleague == colleague2)
            {
                colleague1?.Notify(msg);
            }
        }
        public void SetColleague1(Colleague colleague)
        {
            colleague1 = colleague;
        }
        public void SetColleague2(Colleague colleague)
        {
            colleague2 = colleague;
        }
    }
}
