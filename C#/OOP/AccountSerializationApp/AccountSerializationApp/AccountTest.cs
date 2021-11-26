using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace AccountSerializationApp.Model
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            string path = "E:\\SwabhavTech\\C#\\Account.txt";
            Account A = new Account(5000);
            PrintDetails(A);
            A.Withdraw(3000);
            Print_Updated_Details(A);
           
            
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, A);
            stream.Close();
            Console.WriteLine("File has saved at : " + path);


            FileStream stream1 = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter1 = new BinaryFormatter();
            Account A1 = (Account)formatter1.Deserialize(stream1);
            Console.WriteLine(" ");
            Console.WriteLine("After Deserialization :");
            Print_Updated_Details(A1);
            Console.ReadKey();


        }
        public static void PrintDetails(Account A)
        {
            Console.WriteLine("Previous Balance : {0}",A.Balance);
        } 
        public static void Print_Updated_Details(Account A)
        {
            Console.WriteLine("Updated  Balance : {0}",A.Balance);
        }
    }
}
