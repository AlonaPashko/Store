using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IHazardousMaterials : IMaterialProduct
    {
        public double SubstanceClass { get; set; }
        public int NumberUN { get; set; }
    }
}
