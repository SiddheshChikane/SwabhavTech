using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOfListApp.Model
{
    class Dictionary1
    {
        private Dictionary<int, int> d = new Dictionary<int,int>();
        public void AddDict(int key, int value)
        {
            d.Add(key,value);
        }
        public void DisplayDict()
        {
            foreach (KeyValuePair<int,int> dict in d)
            {
                Console.WriteLine(dict.Key + " " + dict.Value);
            }
            Console.WriteLine(" ");
        }
        public void UpdateDict(int key, int value)
        {
            d.Remove(key);
            d.Add(key, value);

        }
        public void DeleteDict(int key)
        {
            d.Remove(key);
        }
    }
}
