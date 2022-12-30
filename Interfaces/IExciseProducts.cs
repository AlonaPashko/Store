using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IExciseProducts : IProduct
    {
        public string LicenceID { get; set; }
        public int LicenceNumber { get; set; }
        public DateTime LicenceTerm { get; set; }
    }
}
