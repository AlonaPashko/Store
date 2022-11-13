using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Exceptions
{
    internal class ExpirationDateException : Exception
    {
        public ExpirationDateException()
        {
            Console.WriteLine("The expiration date has expired");
            Console.ReadLine();
        }
    }
}
