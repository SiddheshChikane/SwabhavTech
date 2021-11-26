using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOfListApp.Model
{
    class HashSet1
    {
        HashSet<int> hashSet = new HashSet<int>();

        public void AddHash( int value)
        {
            hashSet.Add(value);
        }
        public void DisplayHash()
        {
            foreach (int values in hashSet)
            {
                Console.WriteLine(values + " ");
            }
            Console.WriteLine(" ");
        }
        public void UpdateHash( int value1,int value2)
        {
            if (hashSet.Contains(value1))
            {
                hashSet.Remove(value1);
                hashSet.Add(value2);
            }
        }
        public void DeleteHash(int value)
        {
            hashSet.Remove(value);
        }
    }
}
