using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Exceptions
{
    internal class DefectiveProductException : Exception
    {
        public DefectiveProductException()
        {
            Console.WriteLine("This product is defective");
            Console.ReadLine();
        }
    }
}
