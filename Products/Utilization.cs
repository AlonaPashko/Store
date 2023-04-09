using Store.FileOperation;
using Store.Interfaces;
using Store.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    internal class Utilization
    {
        public List<IProduct> UtilizationList { get; set; }

        public Utilization() => UtilizationList = new List<IProduct>();

        public List<IProduct> Add (IProduct product)
        {
            UtilizationList.Add(product);
            return UtilizationList;
        }
        public void DoUtilizationFile(IProduct product)
        {
            FileWriter writer = new FileWriter(@"..\\..\\..\\Files\\UtilizationList.txt");
            writer.WriteExpression(product.ToString());
        }
        
        public override string ToString()
        {
            return Print.PrintList(UtilizationList);
        }
    }
}
