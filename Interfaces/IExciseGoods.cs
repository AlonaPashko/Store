using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IExciseGoods
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public string LicenceID { get; set; }
        public int LicenceNumber { get; set; }
        public DateTime LicenceTerm { get; set; }

        public string PrintLicence();

    }
}
