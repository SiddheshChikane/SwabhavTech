using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperationsApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = "E:\\SwabhavTech\\C#\\Text.txt";
            FileOperations f = new FileOperations();
            f.Write(FilePath);
            Console.ReadKey();

        }
    }
}
