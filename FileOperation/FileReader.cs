using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.FileOperation
{
    internal class FileReader
    {
        public string ReadFromFile(string path)
        {
            string line = "";
            StreamReader reader = new StreamReader(path);
            line += reader.ReadToEnd();
            reader.Close();
            return line;
        }
        public string ReadFromFileWithAttempts()
        {
            int attempts = 0;
            while (true)
            {
                if (attempts >= 3)
                {
                    throw new FileNotFoundException();
                }
                Console.WriteLine("Please, write the path of file: ");
                string path = Console.ReadLine();

                if (!IsFileExists(path))
                {
                    attempts++;
                }
                else
                {
                    return ReadFromFile(path);
                }
            }
        }
        public bool IsFileExists(string path)
        {
            if (!File.Exists(path))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }

}
