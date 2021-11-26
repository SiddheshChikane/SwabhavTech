using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp.Model
{
    class Todo
    {
        public string FilePath = "E:\\SwabhavTech\\C#\\Text\\ToDoFile.txt";
        public void AddToList(string add)
        {
            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
                sw.WriteLine(add.ToString());
                Console.WriteLine("Task Successfully Added.");
                Console.WriteLine(" ");
                sw.Close();
            }
        }
        public void Display()
        {
            FileStream F = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            StreamReader S = new StreamReader(F);
            string str = S.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = S.ReadLine();
            }
            Console.ReadLine();
            F.Close();
            S.Close();

        }
        public void Exit()
        {
            FileStream F1 = new FileStream(FilePath, FileMode.Append, FileAccess.Write);
            StreamWriter S1 = new StreamWriter(F1);
            Console.WriteLine("Saving The File........");
            Console.WriteLine("Exit from Task...");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}
