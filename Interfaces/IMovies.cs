using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    internal interface IMovies : IProduct
    {
        public int Genre { get; set; }
        public int YearOfRelease { get; set; }
    }
}
