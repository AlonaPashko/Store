using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Exceptions
{
    internal class NoAvailableException : Exception
    {
        public NoAvailableException()
        {
            Console.WriteLine("This product isn't exist");
            Console.ReadLine();
        }
    }
}
