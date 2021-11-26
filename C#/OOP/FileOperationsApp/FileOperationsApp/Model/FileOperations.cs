using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileOperationsApp.Model
{
    class FileOperations
    {
        public void Write(string FilePath)
        {
            StreamWriter w = new StreamWriter(FilePath);
            string data = Console.ReadLine();
            w.WriteLine(data);
            w.Close();
        }
        
    }
}
