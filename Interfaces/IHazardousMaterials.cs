using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IHazardousMaterials
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double SubstanceClass { get; set; }
        public int NumberUN { get; set; }

        public string PrintSubstance();

    }
}
