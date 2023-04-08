using Store.Interfaces;
using Store.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.FileOperation
{
    
    internal class FileWriter : IExpressionWriter
    {
        private string filePath;

        public string FilePath
        {
            get => filePath;
            set { if (value != null) filePath = value; }
        }

        public FileWriter()
        {
            filePath = @"..\\..\\..\\Files\\AddedProducts.txt";
        }

        public FileWriter(string filePath)
        {
            FilePath = filePath;
        }

        public void WriteExpression(object obj)
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                writer.Write(obj.ToString());
            }
        }
    }
}

